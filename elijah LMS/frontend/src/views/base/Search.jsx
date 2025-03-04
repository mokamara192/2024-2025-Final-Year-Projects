import { useEffect, useState, useContext } from "react";
import BaseHeader from "../partials/BaseHeader";
import BaseFooter from "../partials/BaseFooter";
import { Link } from "react-router-dom";
import Rater from "react-rater";
import "react-rater/lib/react-rater.css";

import useAxios from "../../utils/useAxios";
import CartId from "../plugin/CartId";
import GetCurrentAddress from "../plugin/UserCountry";
import UserData from "../plugin/UserData";
import Toast from "../plugin/Toast";
import { CartContext } from "../plugin/Context";
import apiInstance from "../../utils/axios";

function Search() {
    const [courses, setCourses] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    const [cartCount, setCartCount] = useContext(CartContext);

    const country = GetCurrentAddress().country;
    const userId = UserData()?.user_id;
    const cartId = CartId();

    const fetchCourse = async () => {
        setIsLoading(true);
        try {
            const res = await useAxios.get(`/course/course-list/`);
            setCourses(res.data);
            setIsLoading(false);
        } catch (error) {
            console.error(error);
        }
    };

    useEffect(() => {
        fetchCourse();
    }, []);

    const addToCart = async (courseId) => {
        const formdata = new FormData();
        formdata.append("course_id", courseId);
        formdata.append("user_id", userId);
        formdata.append("price", courses.find(course => course.id === courseId)?.price || 0);
        formdata.append("country_name", country);
        formdata.append("cart_id", cartId);

        try {
            await useAxios.post(`course/cart/`, formdata);
            Toast().fire({
                title: "Added To Cart",
                icon: "success",
            });
            const res = await apiInstance.get(`course/cart-list/${cartId}/`);
            setCartCount(res.data?.length);
        } catch (error) {
            console.error(error);
        }
    };

    const [searchQuery, setSearchQuery] = useState("");
    const handleSearch = (e) => {
        const query = e.target.value.toLowerCase();
        setSearchQuery(query);
        setCourses(
            query === ""
                ? courses
                : courses.filter((course) => course.title.toLowerCase().includes(query))
        );
    };

    return (
        <>
            <BaseHeader />
            <section className="mb-5" style={{ marginTop: "100px" }}>
                <div className="container mb-lg-8">
                    <div className="row mb-5 mt-3">
                        <div className="col-12">
                            <div className="mb-6">
                                <h2 className="mb-1 h1">Showing Results for "{searchQuery || "No Search Query"}"</h2>
                            </div>
                        </div>
                        <div className="row">
                            <div className="col-lg-6">
                                <input
                                    type="text"
                                    className="form-control lg mt-3"
                                    placeholder="Search Courses..."
                                    onChange={handleSearch}
                                />
                            </div>
                        </div>
                    </div>
                    <div className="row">
                        <div className="col-md-12">
                            <div className="row row-cols-1 row-cols-md-2 row-cols-lg-4 g-4">
                                {courses?.map((c) => (
                                    <div className="col" key={c.id}>
                                        <div className="card card-hover">
                                            <Link to={`/course-detail/${c.slug}/`}>
                                                <img
                                                    src={c.image}
                                                    alt={c.title}
                                                    className="card-img-top"
                                                    style={{ width: "100%", height: "200px", objectFit: "cover" }}
                                                />
                                            </Link>
                                            <div className="card-body">
                                                <div className="d-flex justify-content-between align-items-center mb-3">
                                                    <div>
                                                        <span className="badge bg-info">{c.level}</span>
                                                        <span className="badge bg-success ms-2">{c.language}</span>
                                                    </div>
                                                    <a href="#" className="fs-5">
                                                        <i className="fas fa-heart text-danger align-middle" />
                                                    </a>
                                                </div>
                                                <h4 className="mb-2 text-truncate-line-2">
                                                    <Link to={`/course-detail/${c.slug}/`} className="text-inherit text-decoration-none text-dark fs-5">
                                                        {c.title}
                                                    </Link>
                                                </h4>
                                                <small>By: {c.teacher.full_name}</small> <br />
                                                <small>{c.students?.length} Student{c.students?.length > 1 && "s"}</small>
                                                <div className="lh-1 mt-3 d-flex">
                                                    <Rater total={5} rating={c.average_rating || 0} />
                                                    <span className="text-warning ms-2">{c.average_rating || "N/A"}</span>
                                                    <span className="fs-6 ms-2">({c.reviews?.length} Reviews)</span>
                                                </div>
                                            </div>
                                            <div className="card-footer">
                                                <div className="row align-items-center g-0">
                                                    <div className="col">
                                                        <h5 className="mb-0">${c.price}</h5>
                                                    </div>
                                                    <div className="col-auto">
                                                    <button type="button" onClick={() => addToCart(c.id, userId, c.price, country, cartId)} className="text-inherit text-decoration-none btn btn-primary btn-sm me-2">
                                                    <i className="fas fa-shopping-cart" />
                                                </button>
                                                <Link to={`/course-detail/${c.slug}/`} className="text-inherit text-decoration-none btn btn-outline-primary btn-sm">
                                                    Enroll Now <i className="fas fa-arrow-right me-2" />
                                                </Link>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                ))}
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <BaseFooter />
        </>
    );
}

export default Search;