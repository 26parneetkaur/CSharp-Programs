$(document).ready(function () {
    alert("document ready occurred!");
});

$(window).load(function () {
    alert("window load occurred!");
});
$(window).on("unload", function () {
    this.console.log("Goodbye!!!")
});
$(window).resize(function () {
    this.console.log("Handler for resize called");
});
function validateForm() {
    var isValid = true;
    var numberRegix = /^[0-9]$/;
    var emailRegix = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
    var salaryRegix = /^\d{1,6}(?:\.\d{0,2})?$/;
    var passwordRegix = /^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$/;
    $("#Name_ErrorMessage").text("");
    $("#Age_ErrorMessage").text("");
    $("#Salary_ErrorMessage").text("");
    $("#Designation_ErrorMessage").text("");
    $("#Gender_ErrorMessage").text("");
    $("#Password_ErrorMessage").text("");
    $("#Email_ErrorMessage").text("");
    $("#Country_ErrorMessage").text("");

    if ($("#Name").val().trim() == "") {
        $("#Name_ErrorMessage").text("Name is Required");
        isValid = false;
    }

    if ($("#Age").val().trim() == "") {
        $("#Age_ErrorMessage").text("Age is Required");
        isValid = false;
    }
    
    if ($("#Age").val().trim() != "" && !numberRegix.test($("#Age").val().trim())) {
        $("#Age_ErrorMessage").text("Age is INVALID");
    }

    if ($("#Salary").val().trim() == "") {
        $("#Salary_ErrorMessage").text("Salary is Required");
        isValid = false;
    }
    if ($("#Salary").val().trim() != "" && !salaryRegix.test($("#Salary").val().trim())) {
        $("#Salary_ErrorMessage").text("Max six digits, a dot, max two digits after dot");
    }

    if ($("#Designation").val().trim() == "") {
        $("#Designation_ErrorMessage").text("Designation is Required");
        isValid = false;
    }

    if ($("#TypeGender").val().trim() == "0") {
        $("#Gender_ErrorMessage").text("Gender is Required");
        isValid = false;
    }

    if ($("#Password").val().trim() == "") {
        $("#Password_ErrorMessage").text("Paassword is Required");
        isValid = false;
    }
    if ($("#Password").val().trim() != "" && !passwordRegix.test($("#Password").val().trim())) {
        $("#Password_ErrorMessage").text("Must contain Minimum eight characters, at least one letter and one number");
    }

    if ($("#Email").val().trim() == "") {
        $("#Email_ErrorMessage").text("Email is Required");
        isValid = false;
    }
    if ($("#Email").val().trim() != "" && !emailRegix.test($("#Email").val().trim())) {
        $("#Email_ErrorMessage").text("Email is INVALID");
    }
    return isValid;
}



function submitForm() {
    if (validateForm()) {
        $("#EmployeeForm").submit();
    }
}

function HandleKeyUp() {
    $("#Email_ErrorMessage").text("");
    var emailRegix = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
    if ($("#Email").val().trim() == "") {
        $("#Email_ErrorMessage").text("Email is Required");
        isValid = false;
    }
    if ($("#Email").val().trim() != "" && !emailRegix.test($("#Email").val().trim())) {
        $("#Email_ErrorMessage").text("Email is INVALID");
    }
}

function HandleChangeAge() {
    $("#Age_ErrorMessage").text("");
    var numberRegix = /^[0-9]$/;
    if ($("#Age").val().trim() == "") {
        $("#Age_ErrorMessage").text("Age is Required");
        isValid = false;
    }

    if ($("#Age").val().trim() != "" && !numberRegix.test($("#Age").val().trim())) {
        $("#Age_ErrorMessage").text("Age is INVALID");
    }
}