document.getElementById("registerForm").addEventListener("submit", function(event) {
    event.preventDefault();
    var username = document.getElementById("username").value;
    var email = document.getElementById("email").value;
    var password = document.getElementById("password").value;
    var confirmPassword = document.getElementById("confirmPassword").value;
    // Perform register validation here
    // If registration is successful, redirect to home page
    // If registration fails, display error message in #errorMsg element
    var errorMsg = document.getElementById("errorMsg");
    errorMsg.textContent = "Registration failed. Please check your input.";
  });
  