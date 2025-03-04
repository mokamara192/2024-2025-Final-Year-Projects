import React, { useState, useEffect, useRef } from "react";
import Sidebar from "./Partials/Sidebar";
import Header from "./Partials/Header";
import Modal from "react-bootstrap/Modal";
import moment from "moment";

import BaseHeader from "../partials/BaseHeader";
import BaseFooter from "../partials/BaseFooter";
import { Link } from "react-router-dom";

import useAxios from "../../utils/useAxios";
import UserData from "../plugin/UserData";

function QA() {
    const [questions, setQuestions] = useState([]);
    const [selectedConversation, setSelectedConversation] = useState(null);
    const lastElementRef = useRef(null);
    const [createMessage, setCreateMessage] = useState({ message: "" });
    const [ConversationShow, setConversationShow] = useState(false);

    // Fetch questions
    const fetchQuestions = async () => {
        try {
            const response = await useAxios.get(`teacher/question-answer-list/${UserData()?.teacher_id}/`);
            setQuestions(response.data);
        } catch (error) {
            console.error("Error fetching questions:", error);
        }
    };

    useEffect(() => {
        fetchQuestions();
    }, []);

    // Open conversation modal
    const handleConversationShow = (conversation) => {
        setSelectedConversation(conversation);
        setConversationShow(true);
    };

    // Close conversation modal
    const handleConversationClose = () => {
        setConversationShow(false);
        setSelectedConversation(null);
    };

    // Handle message input change
    const handleMessageChange = (event) => {
        setCreateMessage({ ...createMessage, [event.target.name]: event.target.value });
    };

    // Send new message
    const sendNewMessage = async (e) => {
        e.preventDefault();
        if (!selectedConversation) return;

        try {
            const formData = new FormData();
            formData.append("course_id", selectedConversation?.course);
            formData.append("user_id", UserData()?.user_id);
            formData.append("message", createMessage.message);
            formData.append("qa_id", selectedConversation?.qa_id);

            const response = await useAxios.post(`student/question-answer-message-create/`, formData);
            setSelectedConversation(response.data.question);
            setCreateMessage({ message: "" });
        } catch (error) {
            console.error("Error sending message:", error);
        }
    };

    // Auto-scroll to the last message
    useEffect(() => {
        if (lastElementRef.current) {
            lastElementRef.current.scrollIntoView({ behavior: "smooth" });
        }
    }, [selectedConversation]);

    // Search questions
    const handleSearchQuestion = (event) => {
        const query = event.target.value.toLowerCase();
        if (!query) {
            fetchQuestions();
        } else {
            const filtered = questions.filter((q) => q.title.toLowerCase().includes(query));
            setQuestions(filtered);
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
                            <h4 className="mb-1">
                                <i className="fas fa-envelope"></i> Question and Answer
                            </h4>

                            <div className="card">
                                <div className="card-header border-bottom p-0 pb-3">
                                    <h4 className="mb-3 p-3">Discussion</h4>
                                    <form className="row g-4 p-3">
                                        <div className="col-sm-12 col-lg-12">
                                            <input
                                                className="form-control pe-5 bg-transparent"
                                                type="search"
                                                placeholder="Search Questions"
                                                aria-label="Search"
                                                onChange={handleSearchQuestion}
                                            />
                                        </div>
                                    </form>
                                </div>

                                <div className="card-body p-0 pt-3">
                                    <div className="vstack gap-3 p-3">
                                        {questions.length > 0 ? (
                                            questions.map((q) => (
                                                <div className="shadow rounded-3 p-3" key={q.qa_id}>
                                                    <div className="d-sm-flex justify-content-sm-between mb-3">
                                                        <div className="d-flex align-items-center">
                                                            <div className="avatar avatar-sm flex-shrink-0">
                                                                <img
                                                                    src={q.profile.image}
                                                                    className="avatar-img rounded-circle"
                                                                    alt="avatar"
                                                                    style={{
                                                                        width: "60px",
                                                                        height: "60px",
                                                                        borderRadius: "50%",
                                                                        objectFit: "cover",
                                                                    }}
                                                                />
                                                            </div>
                                                            <div className="ms-2">
                                                                <h6 className="mb-0">
                                                                    <a href="#" className="text-decoration-none text-dark">
                                                                        {q.profile.full_name}
                                                                    </a>
                                                                </h6>
                                                                <small>{moment(q.date).format("DD MMM, YYYY")}</small>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <h5>
                                                        {q.title} <span className="badge bg-success">{q.messages?.length}</span>
                                                    </h5>
                                                    <button className="btn btn-primary btn-sm mb-3 mt-3" onClick={() => handleConversationShow(q)}>
                                                        Join Conversation <i className="fas fa-arrow-right"></i>
                                                    </button>
                                                </div>
                                            ))
                                        ) : (
                                            <p>No Questions</p>
                                        )}
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>

            {/* Conversation Modal */}
            <Modal show={ConversationShow} size="lg" onHide={handleConversationClose}>
                <Modal.Header closeButton>
                    <Modal.Title>Lesson: {selectedConversation?.title}</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    <div className="border p-2 p-sm-4 rounded-3">
                        <ul className="list-unstyled mb-0" style={{ overflowY: "scroll", height: "500px" }}>
                            {selectedConversation?.messages?.map((m) => (
                                <li className="comment-item mb-3" key={m.id}>
                                    <div className="d-flex">
                                        <div className="avatar avatar-sm flex-shrink-0">
                                            <a href="#">
                                                <img
                                                    className="avatar-img rounded-circle"
                                                    src={m.profile.image?.startsWith("http://127.0.0.1:8000") ? m.profile.image : `http://127.0.0.1:8000${m.profile.image}`}
                                                    style={{
                                                        width: "40px",
                                                        height: "40px",
                                                        borderRadius: "50%",
                                                        objectFit: "cover",
                                                    }}
                                                    alt="user avatar"
                                                />
                                            </a>
                                        </div>
                                        <div className="ms-2">
                                            <div className="bg-light p-3 rounded w-100">
                                                <h6 className="mb-1 lead fw-bold">
                                                    <a href="#!" className="text-decoration-none text-dark">
                                                        {m.profile.full_name}
                                                    </a>
                                                    <br />
                                                    <span style={{ fontSize: "12px", color: "gray" }}>{moment(m.date).format("DD MMM, YYYY")}</span>
                                                </h6>
                                                <p className="mb-0 mt-3">{m.message}</p>
                                            </div>
                                        </div>
                                    </div>
                                </li>
                            ))}
                            <div ref={lastElementRef}></div>
                        </ul>

                        <form className="w-100 d-flex" onSubmit={sendNewMessage}>
                            <textarea name="message" className="form-control pe-4 bg-light w-75" rows="5" onChange={handleMessageChange} placeholder="what is your respons?" />
                            <button className="btn btn-primary ms-2 w-25" type="submit">
                                Post <i className="fas fa-paper-plane"></i>
                            </button>
                        </form>
                    </div>
                </Modal.Body>
            </Modal>

            <BaseFooter />
        </>
    );
}

export default QA;
