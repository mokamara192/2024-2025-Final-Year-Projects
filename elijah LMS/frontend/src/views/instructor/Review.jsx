import { useState, useEffect } from "react";
import moment from "moment";
import Rater from "react-rater";
import "react-rater/lib/react-rater.css";

import Sidebar from "./Partials/Sidebar";
import Header from "./Partials/Header";
import BaseHeader from "../partials/BaseHeader";
import BaseFooter from "../partials/BaseFooter";

import useAxios from "../../utils/useAxios";
import UserData from "../plugin/UserData";
import { teacherId } from "../../utils/constants";
import Swal from "sweetalert2";  // Correct import for SweetAlert2

function Review() {
    const [reviews, setReviews] = useState([]);
    const [filteredReviews, setFilteredReview] = useState([]);
    const [replies, setReplies] = useState({});  // Store replies by review ID

    // Fetch reviews data
    const fetchReviewsData = async () => {
        try {
            const res = await useAxios.get(`teacher/review-lists/${teacherId}/`);
            setReviews(res.data);
            setFilteredReview(res.data);
        } catch (error) {
            console.error("Error fetching reviews:", error);
        }
    };

    useEffect(() => {
        fetchReviewsData();
    }, []);

    // Handle reply submission
    const handleSubmitReply = async (reviewId) => {
        try {
            await useAxios.patch(`teacher/review-detail/${teacherId}/${reviewId}/`, {
                reply: replies[reviewId] || "",
            });
            fetchReviewsData(); // Refresh reviews after replying
            Swal.fire({  // Use Swal.fire for the toast notification
                icon: "success",
                title: "Reply sent.",
                toast: true, // This makes it a toast
                position: 'top-end',
                showConfirmButton: false,
                timer: 3000,
            });
            setReplies((prev) => ({ ...prev, [reviewId]: "" })); // Reset reply field for this review
        } catch (error) {
            console.error("Error submitting reply:", error);
        }
    };

    // Handle sorting reviews by date
    const handleSortByDate = (e) => {
        const sortValue = e.target.value;
        let sortedReview = [...filteredReviews];
        if (sortValue === "Newest") {
            sortedReview.sort((a, b) => new Date(b.date) - new Date(a.date));
        } else {
            sortedReview.sort((a, b) => new Date(a.date) - new Date(b.date));
        }

        setFilteredReview(sortedReview);
    };

    // Handle sorting reviews by rating
    const handleSortByRatingChange = (e) => {
        const rating = parseInt(e.target.value);
        if (rating === 0) {
            fetchReviewsData(); // Reset if 'Rating' is selected
        } else {
            const filtered = reviews.filter((review) => review.rating === rating);
            setFilteredReview(filtered);
        }
    };

    // Handle filtering reviews by course name
    const handleFilterByCourse = (e) => {
        const query = e.target.value.toLowerCase();
        if (query === "") {
            fetchReviewsData(); // Reset if query is empty
        } else {
            const filtered = reviews.filter((review) => {
                return review.course.title.toLowerCase().includes(query);
            });
            setFilteredReview(filtered);
        }
    };

    return (
        <>
            <BaseHeader />
            <section className="pt-5 pb-5">
                <div className="container">
                    <Header />
                    <div className="row mt-0 mt-md-4">
                        <Sidebar />
                        <div className="col-lg-9 col-md-8 col-12">
                            <div className="card mb-4">
                                <div className="card-header d-lg-flex align-items-center justify-content-between">
                                    <div className="mb-3 mb-lg-0">
                                        <h3 className="mb-0">Reviews</h3>
                                        <span>You have full control to manage your own account setting.</span>
                                    </div>
                                </div>
                                <div className="card-body">
                                    <form className="row mb-4 gx-2">
                                        <div className="col-xl-7 col-lg-6 col-md-4 col-12 mb-2 mb-lg-0">
                                            <input type="text" className="form-control" placeholder="Search By Course" onChange={handleFilterByCourse} />
                                        </div>
                                        <div className="col-xl-2 col-lg-2 col-md-4 col-12 mb-2 mb-lg-0">
                                            <select className="form-select" onChange={handleSortByRatingChange}>
                                                <option value={0}>Rating</option>
                                                <option value={1}>1</option>
                                                <option value={2}>2</option>
                                                <option value={3}>3</option>
                                                <option value={4}>4</option>
                                                <option value={5}>5</option>
                                            </select>
                                        </div>
                                        <div className="col-xl-3 col-lg-3 col-md-4 col-12 mb-2 mb-lg-0">
                                            <select className="form-select" onChange={handleSortByDate}>
                                                <option value="">Sort by</option>
                                                <option value="Newest">Newest</option>
                                                <option value="Oldest">Oldest</option>
                                            </select>
                                        </div>
                                    </form>
                                    <ul className="list-group list-group-flush">
                                        {filteredReviews?.map((r) => (
                                            <li className="list-group-item p-4 shadow rounded-3 mb-4" key={r.id}>
                                                <div className="d-flex">
                                                    <img src={r.profile.image} alt="avatar" className="rounded-circle avatar-lg" style={{ width: "70px", height: "70px", borderRadius: "50%", objectFit: "cover" }} />
                                                    <div className="ms-3 mt-2">
                                                        <div className="d-flex align-items-center justify-content-between">
                                                            <div>
                                                                <h4 className="mb-0">{r.profile.full_name}</h4>
                                                                <span>{moment(r.date).format("DD MMM, YYYY")}</span>
                                                            </div>
                                                            <div>
                                                                <a href="#" data-bs-toggle="tooltip" data-placement="top" title="Report Abuse">
                                                                    <i className="fe fe-flag" />
                                                                </a>
                                                            </div>
                                                        </div>
                                                        <div className="mt-2">
                                                            <span className="fs-6 me-1 align-top">
                                                                <Rater total={5} rating={r.rating || 0} />
                                                            </span>
                                                            <span className="me-1">for</span>
                                                            <span className="h5">{r.course?.title}</span>
                                                            <p className="mt-2">
                                                                <span className="fw-bold me-2">
                                                                    Review <i className="fas fa-arrow-right"></i>
                                                                </span>
                                                                {r.review}
                                                            </p>
                                                            <p className="mt-2">
                                                                <span className="fw-bold me-2">
                                                                    Response <i className="fas fa-arrow-right"></i>
                                                                </span>
                                                                {r.reply || "No Reply"}
                                                            </p>
                                                            <p>
                                                                <button className="btn btn-outline-secondary" type="button" data-bs-toggle="collapse" data-bs-target={`#collapse${r.id}`} aria-expanded="false" aria-controls={`collapse${r.id}`}>
                                                                    Send Response
                                                                </button>
                                                            </p>
                                                            <div className="collapse" id={`collapse${r.id}`}>
                                                                <div className="card card-body">
                                                                    <div>
                                                                        <div className="mb-3">
                                                                            <label className="form-label">Write Response</label>
                                                                            <textarea
                                                                                cols="30"
                                                                                className="form-control"
                                                                                rows="4"
                                                                                value={replies[r.id] || ""}
                                                                                onChange={(e) => setReplies((prev) => ({ ...prev, [r.id]: e.target.value }))} 
                                                                            />
                                                                        </div>
                                                                        <button type="button" className="btn btn-primary" onClick={() => handleSubmitReply(r.id)}>
                                                                            Send Response <i className="fas fa-paper-plane"></i>
                                                                        </button>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </li>
                                        ))}
                                        {filteredReviews?.length < 1 && <p className="mt-4 p-3">No reviews</p>}
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <BaseFooter />
        </>
    );
}

export default Review;
