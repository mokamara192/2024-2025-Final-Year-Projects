import Swal from "sweetalert2";

function Toast(icon, title) {
    const Toast = Swal.mixin({
        toast: true,
        position: "top",
        showConfirmButton: false,
        timer: 1500,
        timerProgressBar: true,
    });

    return Toast.fire({ icon: icon, title: title });
}

export default Toast;
