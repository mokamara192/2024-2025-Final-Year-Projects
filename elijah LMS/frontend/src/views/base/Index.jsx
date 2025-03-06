import { useEffect, useState, useContext } from "react";
import BaseHeader from "../partials/BaseHeader";
import BaseFooter from "../partials/BaseFooter";
import { Link } from "react-router-dom";
import Rater from "react-rater";
import "react-rater/lib/react-rater.css";

import CartId from "../plugin/CartId";
import GetCurrentAddress from "../plugin/UserCountry";
import UserData from "../plugin/UserData";
import Toast from "../plugin/Toast";
import { CartContext } from "../plugin/Context";
import apiInstance from "../../utils/axios";

function Index() {
  const [courses, setCourses] = useState([]);
  const [isLoading, setIsLoading] = useState(true);
  const [cartCount, setCartCount] = useContext(CartContext);

  const country = GetCurrentAddress().country;
  const userId = UserData()?.user_id;
  const cartId = CartId();

  const fetchCourse = async () => {
    setIsLoading(true);
    try {
      await apiInstance.get(`/course/course-list/`).then((res) => {
        setCourses(res.data);
        setIsLoading(false);
      });
    } catch (error) {
      console.log(error);
    }
  };

  useEffect(() => {
    fetchCourse();
  }, []);

  const addToCart = async (courseId, userId, price, country, cartId) => {
    const formdata = new FormData();

    formdata.append("course_id", courseId);
    formdata.append("user_id", userId);
    formdata.append("price", price);
    formdata.append("country_name", country);
    formdata.append("cart_id", cartId);

    try {
      await apiInstance.post(`course/cart/`, formdata).then((res) => {
        console.log(res.data);
        Toast("success", "Added To Cart");

        // Set cart count after adding to cart
        apiInstance.get(`course/cart-list/${CartId()}/`).then((res) => {
          setCartCount(res.data?.length);
        });
      });
    } catch (error) {
      console.log(error);
    }
  };

  // Pagination
  const itemsPerPage = 4;
  const [currentPage, setCurrentPage] = useState(1);
  const indexOfLastItem = currentPage * itemsPerPage;
  const indexOfFirstItem = indexOfLastItem - itemsPerPage;
  const currentItems = courses.slice(indexOfFirstItem, indexOfLastItem);
  const totalPages = Math.ceil(courses.length / itemsPerPage);
  const pageNumbers = Array.from(
    { length: totalPages },
    (_, index) => index + 1
  );

  const addToWishlist = (courseId) => {
    const formdata = new FormData();
    formdata.append("user_id", UserData()?.user_id);
    formdata.append("course_id", courseId);

    apiInstance
      .post(`student/wishlist/${UserData()?.user_id}/`, formdata)
      .then((res) => {
        console.log(res.data);
        Toast().fire({
          icon: "success",
          title: res.data.message,
        });
      });
  };

  return (
    <>
      <BaseHeader />

      <section className="py-lg-8 py-5 pt-5">
        <div className="container my-lg-8">
          <div className="row align-items-center">
            <div className="col-lg-6 mb-6 mb-lg-0">
              <div>
                <h1 className="display-3 fw-bold mb-3">
                  <span className="text-primary fw-bold">Enhance</span> Your
                  Knowledge
                  <br />
                  and <span className="text-primary fw-bold">Elevate</span> Your
                  Future
                </h1>
                <p className="pe-lg-10 mb-5 text-lg-start text-center text-muted fw-medium">
                  <span className="text-primary fw-bold">
                    Take the next step
                  </span>{" "}
                  in your career—
                  <span className="text-success fw-bold">start</span>,
                  <span className="text-warning fw-bold">switch</span>, or
                  <span className="text-danger fw-bold"> advance</span> with
                  access to
                  <span className="text-primary fw-bold">5,000+</span>{" "}
                  expert-led courses designed to help you{" "}
                  <span className="text-info fw-bold">succeed</span>.
                </p>
                {/* <div className="d-flex gap-3 flex-wrap">
                                    <a href="#" className="btn btn-primary">
                                        Browse Courses <i className="fas fa-arrow-right ms-1"></i>
                                    </a>
                                    <a href="#" className="btn btn-outline-primary">
                                        Learn More <i className="fas fa-video ms-1"></i>
                                    </a>
                                </div>*/}
              </div>
            </div>
            {/* col */}
            <div className="col-lg-6 d-flex justify-content-center">
              {/* images */}
              <div className="position-relative">
                <img src="images/top image.jpg" />
              </div>
            </div>
          </div>
        </div>
      </section>

      <section className="mb-5 bg-light py-5">
        <div className="container mb-lg-8 ">
          <div className="row mb-5 mt-3">
            {/* col */}
            <div className="col-12">
              <div className="mb-6">
                <h2 className="mb-1 h1 fw-bolder text-center">
                  Popular Courses 🔥
                </h2>
                <p className="text-secondary  text-center">
                  These are the most popular courses on Elijah's LMS, choose a
                  course and start learning
                </p>
              </div>
            </div>
          </div>
          <div className="row">
            {currentItems?.map((c, index) => (
              <div className="col-lg-3">
                <div className="card border shadow mb-4">
                  <Link to={`/course-detail/${c.slug}/`}>
                    <img
                      src={c.image}
                      alt="course"
                      className="card-img-top"
                      style={{
                        width: "100%",
                        height: "200px",
                        objectFit: "cover",
                      }}
                    />
                  </Link>
                  <div className="card-body">
                    <div className="d-flex justify-content-between align-items-center mb-3">
                      <div>
                        <span className="badge bg-dark">{c.level}</span>
                        <span className="badge bg-warning text-dark ms-2">
                          {c.language}
                        </span>
                      </div>
                      <a onClick={() => addToWishlist(c.id)} className="fs-5">
                        <i className="fas fa-heart text-danger align-middle" />
                      </a>
                    </div>
                    <h4 className="mb-2 text-truncate-line-2 ">
                      <Link
                        to={`/course-detail/${c.slug}/`}
                        className="text-inherit text-decoration-none text-dark fw-bold fs-5"
                      >
                        {c.title}
                      </Link>
                    </h4>
                    <small>By: {c.teacher.full_name}</small> <br />
                    <small>
                      {c.students?.length} Student
                      {c.students?.length > 1 && "s"}
                    </small>{" "}
                    <br />
                    <div className="lh-1 mt-3 d-flex">
                      <span className="align-text-top">
                        <span className="fs-6">
                          <Rater total={5} rating={c.average_rating || 0} />
                        </span>
                      </span>
                      <span className="fs-6 ms-2">
                        ({c.reviews?.length} Reviews)
                      </span>
                    </div>
                  </div>
                  <div className="card-footer">
                    <div className="row align-items-center g-0">
                      <div className="col">
                        <h5 className="mb-0 fw-bold">Nle{c.price}</h5>
                      </div>
                      <div className="col-auto">
                        <button
                          type="button"
                          onClick={() =>
                            addToCart(c.id, userId, c.price, country, cartId)
                          }
                          className="text-inherit text-decoration-none btn btn-primary btn-sm me-2"
                        >
                          <i className="fas fa-shopping-cart" />
                        </button>
                        <Link
                          to={`/course-detail/${c.slug}/`}
                          className="text-inherit text-decoration-none btn btn-outline-primary btn-sm"
                        >
                          Enroll Now <i className="fas fa-arrow-right me-2" />
                        </Link>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            ))}
          </div>
          <nav className="d-flex mt-5">
            <ul className="pagination">
              <li
                className={`page-item ${currentPage === 1 ? "disabled" : ""}`}
              >
                <button
                  className="page-link me-1"
                  onClick={() => setCurrentPage(currentPage - 1)}
                >
                  <i className="ci-arrow-left me-2" />
                  Previous
                </button>
              </li>
            </ul>
            <ul className="pagination">
              {pageNumbers.map((number) => (
                <li
                  key={number}
                  className={`page-item ${currentPage === number ? "active" : ""}`}
                >
                  <button
                    className="page-link"
                    onClick={() => setCurrentPage(number)}
                  >
                    {number}
                  </button>
                </li>
              ))}
            </ul>

            <ul className="pagination">
              <li
                className={`page-item ${currentPage === totalPages ? "disabled" : ""}`}
              >
                <button
                  className="page-link ms-1"
                  onClick={() => setCurrentPage(currentPage + 1)}
                >
                  Next
                  <i className="ci-arrow-right ms-3" />
                </button>
              </li>
            </ul>
          </nav>
        </div>
      </section>

      <BaseFooter />
    </>
  );
}

export default Index;
