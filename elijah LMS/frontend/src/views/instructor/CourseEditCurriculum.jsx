import { useState, useEffect } from "react";
import { CKEditor } from "@ckeditor/ckeditor5-react";
import ClassicEditor from "@ckeditor/ckeditor5-build-classic";
import Cookie from "js-cookie";
import ReactPlayer from "react-player";
import Button from "react-bootstrap/Button";
import Modal from "react-bootstrap/Modal";

import Sidebar from "./Partials/Sidebar";
import Header from "./Partials/Header";
import BaseHeader from "../partials/BaseHeader";
import BaseFooter from "../partials/BaseFooter";
import { Link, useNavigate, useParams } from "react-router-dom";

import useAxios from "../../utils/useAxios";
import UserData from "../plugin/UserData";
import Swal from "sweetalert2";
import Toast from "../plugin/Toast";

function CourseEditCurriculum() {
    const [courseData, setCourseData] = useState({});
    const [sections, setSections] = useState([]);
    const [showSectionModal, setShowSectionModal] = useState(false);
    const [showLectureModal, setShowLectureModal] = useState(false);
    const [status, setStatus] = useState(false);
    const [selectedSection, setSelectedSection] = useState({});
    const [sectionData, setSectionData] = useState({ title: "", updateTitle: "" });
    const [lectureData, setLectureData] = useState({ title: "", description: "", file: "", preview: false });
    const [previewUrls, setPreviewUrls] = useState({});
    const [lectureFile, setLectureFile] = useState("");

    const [refresh, setRefresh] = useState(false);
    const navigate = useNavigate();
    const param = useParams();

    const handleCloseSectionModal = () => setShowSectionModal(false);
    const handleShowSectionModal = () => setShowSectionModal(true);

    const handleCloseLectureModal = () => setShowLectureModal(false);

    const handleShowLectureModal = (section) => {
        setShowLectureModal(true);
        setSelectedSection(section);
    };

    console.log(selectedSection?.variant_id);

    const handleLessonDataChange = (e) => {
        setLectureData({ ...lectureData, [e.target.name]: e.target.type === "checkbox" ? e.target.checked : e.target.value });
    };

    const handleFileUpload = async (file) => {
        const formData = new FormData();
        formData.append("file", file);

        try {
            const response = await useAxios.post("/file-upload/", formData, {
                headers: {
                    "Content-Type": "multipart/form-data",
                },
            });

            return response?.data?.url;
        } catch (error) {
            console.error("Error uploading file:", error);
            throw error;
        }
    };

    const handleCreateSection = async () => {
        try {
            useAxios.post(`teacher/course-variant/${param?.course_id}/`, { title: sectionData?.title }).then(() => {
                fetchCourseDetail();
                handleCloseSectionModal();
            });
        } catch (error) {
            console.log(error);
        }
    };

    const handleUpdateSection = async (variant_id, section) => {
        try {
            useAxios.put(`teacher/course-variant/${param?.course_id}/`, { title: sectionData?.updateTitle || section?.title, variant_id: variant_id }).then(() => {
                fetchCourseDetail();
                Toast("success", "Section Updated Successfully");
            });
        } catch (error) {
            console.log(error);
        }
    };

    const handleCreateLecture = async () => {
        const json = {
            title: lectureData.title,
            description: lectureData.description,
            preview: lectureData.preview,
            variant_id: selectedSection?.variant_id,
        };
        try {
            useAxios.post(`teacher/course-variant-item/`, json).then((response) => {
                console.log(response?.data);

                fetchCourseDetail();
                setLectureData({ title: "", description: "", file: "", preview: false });
                Toast("success", "Lecture Added Successfully");
            });
        } catch (error) {
            console.log(error);
        }
    };

    const handleUpdateLecture = async (lecture, lectureFileObj) => {
        const json = {
            title: lectureData.title || lecture?.title,
            description: lectureData.description || lecture?.description,
            file: lectureFileObj,
            variant_item_id: lecture?.variant_item_id,
        };
        console.log(json);

        try {
            useAxios.put(`teacher/course-variant-item/`, json).then((response) => {
                fetchCourseDetail();
                Toast("success", "Lecture Updated Successfully");
            });
        } catch (error) {
            console.log(error);
        }
    };

    const handleDeleteLecture = async (lecture) => {
        console.log(lecture?.variant_item_id);

        try {
            useAxios.delete(`teacher/course-variant-item/`, { data: { variant_item_id: lecture?.variant_item_id } }).then((response) => {
                fetchCourseDetail();
                Toast("success", "Lecture Deleted Successfully");
            });
        } catch (error) {
            console.log(error);
        }
    };

    const handleDeleteSection = async (section) => {
        try {
            useAxios.delete(`teacher/course-variant/${param?.course_id}/`, { data: { variant_id: section?.variant_id } }).then((response) => {
                fetchCourseDetail();
                Toast("success", "Section Deleted Successfully");
            });
        } catch (error) {
            console.log(error);
        }
    };

    const handleUpdateLecturePreview = async (preview, lecture) => {
        const json = {
            preview: preview,
            variant_item_id: lecture?.variant_item_id,
        };
        try {
            useAxios.post(`teacher/course-variant-item-preview/`, json).then((response) => {
                fetchCourseDetail();
                Toast("success", "Lecture Updated Successfully");
            });
        } catch (error) {
            console.log(error);
        }
    };

    const fetchCourseDetail = () => {
        useAxios.get(`teacher/course-variant/${param?.course_id}/`).then((res) => {
            setSections(res.data);
        });

        useAxios.get(`teacher/course-detail/${param.course_id}/`).then((res) => {
            setCourseData(res.data);
        });
    };

    useEffect(() => {
        fetchCourseDetail();
    }, []);
    console.log(lectureFile);

    return (
        <>
            <BaseHeader />

            <section className="pt-5 pb-5">
                <div className="container">
                    <Header />
                    <div className="row mt-0 mt-md-4">
                        <Sidebar />
                        <div className="col-lg-9 col-md-8 col-12">
                            <section className="pb-8 mt-5">
                                <div className="card mb-3">
                                    {/* Basic Info Section */}
                                    <div className="card-header border-bottom px-4 py-3 d-flex justify-content-between align-items-center">
                                        <h4 className="mb-0 fw-bold">Curriculum</h4>
                                        <Link to={`/instructor/edit-course/${param?.course_id}/`} className="btn btn-primary btn-sm">
                                            <i className="fas fa-arrow-left me-2"></i> Manage Course Info
                                        </Link>
                                    </div>
                                    <div className="card-body" key={sections?.length}>
                                        {sections?.map((section, sectionIndex) => (
                                            <div className="section mb-3 bg-light border p-2 rounded-3">
                                                <div className="d-flex align-items-center justify-content-between">
                                                    <div className="d-flex align-items-center gap-3 w-100">
                                                        <h5>Section {sectionIndex + 1}</h5>
                                                        <div className="w-50">
                                                            <input type="text" onChange={(e) => setSectionData({ updateTitle: e.target.value })} defaultValue={section?.title} className="form-control" />
                                                        </div>
                                                    </div>
                                                    <div className="mb-3 d-flex gap-2">
                                                        <button onClick={() => handleUpdateSection(section?.variant_id, section)} className="btn btn-sm btn-success">
                                                            <i className="fas fa-save"></i>
                                                        </button>

                                                        <button onClick={() => handleDeleteSection(section)} className="btn btn-sm btn-danger">
                                                            <i className="fas fa-trash"></i>
                                                        </button>
                                                    </div>
                                                </div>
                                                <div className="lectures">
                                                    {section?.items?.map((item, itemIndex) => (
                                                        <div className="ms-5 mt-4 border p-3 rounded-3 shadow ps-4 mb-3">
                                                            <div className="d-flex align-items-end justify-content-between">
                                                                <div className="d-flex flex-column gap-4 w-100">
                                                                    <div className="w-50">
                                                                        <h6>Title</h6>
                                                                        <input onChange={handleLessonDataChange} name="title" type="text" defaultValue={item?.title} className="form-control" />
                                                                    </div>
                                                                    <div className="d-flex align-items-center gap-3 w-100">
                                                                        <div className="w-50">
                                                                            <h6>Description</h6>
                                                                            <textarea onChange={handleLessonDataChange} name="description" type="text" defaultValue={item?.description} className="form-control" />
                                                                        </div>
                                                                    </div>
                                                                    <div className="d-flex align-items-center gap-3 w-100">
                                                                        <h6>Preview</h6>
                                                                        <input name="preview" onChange={() => handleUpdateLecturePreview(!item?.preview, item)} type="checkbox" checked={item?.preview} className="form-check-input" />
                                                                    </div>
                                                                    <div className="d-flex align-items-center gap-3 w-100">
                                                                        <div className="w-50 d-flex flex-column">
                                                                            <h6>Video </h6>

                                                                            <ReactPlayer controls={true} width={"250px"} height={150} url={previewUrls[itemIndex] || item?.file} />
                                                                            <div className="mt-2">
                                                                                <input
                                                                                    type="file"
                                                                                    className="d-none"
                                                                                    id={`file-upload-${sectionIndex}-${itemIndex}`}
                                                                                    onChange={async (e) => {
                                                                                        const file = e.target.files[0];
                                                                                        if (!file) return;

                                                                                        try {
                                                                                            // Generate a local preview URL
                                                                                            const previewUrl = URL.createObjectURL(file);
                                                                                            setPreviewUrls((prev) => ({ ...prev, [itemIndex]: previewUrl }));

                                                                                            // Upload the file
                                                                                            const fileUrl = await handleFileUpload(file);
                                                                                            console.log(fileUrl);
                                                                                            setLectureFile(fileUrl);
                                                                                            // Update lectureData with the new file URL
                                                                                            setLectureData((prev) => ({ ...prev, file: fileUrl.url }));

                                                                                            // Immediately save the lecture
                                                                                            handleUpdateLecture(item, fileUrl);
                                                                                        } catch (error) {
                                                                                            console.error("Error uploading and saving file for lecture:", error);
                                                                                        }
                                                                                    }}
                                                                                />
                                                                                <button className="btn btn-primary btn-sm" onClick={() => document.getElementById(`file-upload-${sectionIndex}-${itemIndex}`).click()}>
                                                                                    Upload Video <i className="fas fa-upload"></i>
                                                                                </button>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <div className="mb-3 d-flex gap-2">
                                                                    <button onClick={() => handleUpdateLecture(item)} className="btn btn-sm btn-outline-success">
                                                                        <i className="fas fa-save"></i>
                                                                    </button>

                                                                    <button onClick={() => handleDeleteLecture(item)} className="btn btn-sm btn-outline-danger">
                                                                        <i className="fas fa-trash"></i>
                                                                    </button>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    ))}
                                                </div>
                                                <button onClick={() => handleShowLectureModal(section)} className="btn btn-outline-dark btn-sm mt-5" type="button">
                                                    Add Lecture <i className="fas fa-plus ms-1"></i>
                                                </button>
                                            </div>
                                        ))}

                                        <button onClick={handleShowSectionModal} className="btn btn-dark" type="button">
                                            Add Section <i className="fas fa-plus ms-1"></i>
                                        </button>
                                    </div>
                                </div>
                            </section>
                        </div>
                    </div>
                </div>

                <Modal show={showLectureModal} onHide={handleCloseLectureModal}>
                    <Modal.Header closeButton>
                        <Modal.Title>Add Lecture</Modal.Title>
                    </Modal.Header>
                    <Modal.Body>
                        <div>
                            <div className="mb-3">
                                <label htmlFor="title" className="form-label">
                                    Title
                                </label>
                                <input onChange={handleLessonDataChange} value={lectureData?.title} name="title" type="text" id="title" className="form-control" placeholder="Lecture Title" />
                            </div>
                            <div className="mb-3">
                                <label htmlFor="description" className="form-label">
                                    Description
                                </label>
                                <input onChange={handleLessonDataChange} value={lectureData?.description} name="description" type="text" id="description" className="form-control" placeholder="Lecture Description" />
                            </div>
                            <div className="mb-3">
                                <label htmlFor="preview" className="form-label me-2">
                                    Preview
                                </label>
                                <input onChange={handleLessonDataChange} checked={lectureData?.preview} name="preview" type="checkbox" id="preview" className="form-check-input" />
                            </div>

                            <Button variant="secondary" className="me-2" onClick={handleCloseLectureModal}>
                                Close
                            </Button>
                            <Button variant="primary" onClick={handleCreateLecture}>
                                Save Changes
                            </Button>
                        </div>
                    </Modal.Body>
                </Modal>

                <Modal show={showSectionModal} onHide={handleCloseSectionModal}>
                    <Modal.Header closeButton>
                        <Modal.Title>Add Section</Modal.Title>
                    </Modal.Header>
                    <Modal.Body>
                        <div className="mb-3">
                            <label htmlFor="title" className="form-label">
                                Title
                            </label>
                            <input onChange={(e) => setSectionData({ title: e.target.value })} type="text" id="title" className="form-control" placeholder="Section Title" />
                        </div>
                        <Button variant="secondary" className="me-2" onClick={handleCloseSectionModal}>
                            Close
                        </Button>
                        <Button variant="primary" onClick={handleCreateSection}>
                            Save Changes
                        </Button>
                    </Modal.Body>
                </Modal>
            </section>

            <BaseFooter />
        </>
    );
}

export default CourseEditCurriculum;
