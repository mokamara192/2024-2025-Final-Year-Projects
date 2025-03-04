import { useState, useEffect } from "react";
import moment from "moment";
import Modal from "react-bootstrap/Modal";
import Button from "react-bootstrap/Button";

import Sidebar from "./Partials/Sidebar";
import Header from "./Partials/Header";
import BaseHeader from "../partials/BaseHeader";
import BaseFooter from "../partials/BaseFooter";

import useAxios from "../../utils/useAxios";
import UserData from "../plugin/UserData";
import Swal from "sweetalert2"; // Ensure correct import

function TeacherNotification() {
    const [noti, setNoti] = useState([]);

    const fetchNoti = () => {
        useAxios.get(`teacher/noti-list/${UserData()?.teacher_id}/`)
            .then((res) => {
                setNoti(res.data);
                console.log(res.data);
            })
            .catch((error) => console.error("Error fetching notifications:", error));
    };

    useEffect(() => {
        fetchNoti();
    }, []);

    const handleMarkAsSeen = (notiId) => {
        const formData = new FormData();
        formData.append("teacher", UserData()?.teacher_id);
        formData.append("pk", notiId);
        formData.append("seen", true);

        useAxios.patch(`teacher/noti-detail/${UserData()?.teacher_id}/${notiId}`, formData)
            .then((res) => {
                console.log(res.data);
                fetchNoti();

                // ✅ Correct Toast Usage
                Swal.fire({
                    icon: "success",
                    title: "Notification Seen",
                    timer: 2000,
                    showConfirmButton: false,
                });
            })
            .catch((error) => {
                console.error("Error marking notification as seen:", error);
                Swal.fire({
                    icon: "error",
                    title: "Error",
                    text: "Failed to mark notification as seen.",
                });
            });
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
                                        <h3 className="mb-0">Notifications</h3>
                                        <span>Manage all your notifications from here</span>
                                    </div>
                                </div>
                                <div className="card-body">
                                    <ul className="list-group list-group-flush">
                                        {noti?.map((n, index) => (
                                            <li className="list-group-item p-4 shadow rounded-3 mb-3" key={index}>
                                                <div className="d-flex">
                                                    <div className="ms-3 mt-2">
                                                        <div className="d-flex align-items-center justify-content-between">
                                                            <div>
                                                                <h4 className="mb-0">{n.type}</h4>
                                                            </div>
                                                        </div>
                                                        <div className="mt-2">
                                                            <p className="mt-1">
                                                                <span className="me-2 fw-bold">
                                                                    Date: <span className="fw-light">{moment(n.date).format("DD MMM, YYYY")}</span>
                                                                </span>
                                                            </p>
                                                            <p>
                                                                <button className="btn btn-outline-secondary" type="button" onClick={() => handleMarkAsSeen(n.id)}>
                                                                    Mark as Seen <i className="fas fa-check"></i>
                                                                </button>
                                                            </p>
                                                        </div>
                                                    </div>
                                                </div>
                                            </li>
                                        ))}

                                        {noti?.length < 1 && <p>No notifications</p>}
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

export default TeacherNotification;
