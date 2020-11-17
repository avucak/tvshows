<template>
  <div class="modal" id="logInForm">
    <div class="modal-content">
      <span class="close">&times;</span>
      <form action="" class="form-container">
        <h1>Login</h1>
        <div class="inputs">
          <label for="email">Email</label>
          <input type="text" placeholder="Enter Email" name="email" required />
        </div>
        <div class="inputs">
          <label for="psw">Password</label>
          <input
            type="password"
            placeholder="Enter Password"
            name="psw"
            required
          />
        </div>

        <button type="submit" class="btn">Login</button>
        <div>Not a member? <a href="#">Sign up now</a></div>
      </form>
    </div>
  </div>
</template>

<script>
export default {
  name: "LogIn",
  methods: {
    openForm() {
      document.getElementById("logInForm").style.display = "block";
    },
    closeForm() {
      document.getElementById("logInForm").style.display = "none";
    },
  },
};
</script>

<style scoped>
.modal {
  position: fixed;
  z-index: 1;
  left: 0;
  top: 0;
  width: 100%;
  background-color: rgb(0, 0, 0); /* Fallback color */
  background-color: rgba(0, 0, 0, 0.4); /* Black w/ opacity */
}

.modal-content {
  background-color: #fefefe;
  margin: 15% auto; /* 15% from the top and centered */
  padding: 20px;
  border: 1px solid #888;
  width: 35%; /* Could be more or less, depending on screen size */
}

.close {
  color: #aaa;
  float: right;
  font-size: 28px;
  font-weight: bold;
}

button {
  background: darkred;
  color: white;
  border: none;
  padding: 10px 18px;
  margin: 24px 15px;
  font-size: 15px;
}

.inputs {
  text-align: left !important;
  margin-left: 14px;
}

form .signup-link a {
  text-decoration: none;
}
form .signup-link a:hover {
  text-decoration: underline;
}

.form-container input[type="text"],
.form-container input[type="password"] {
  width: 90%;
  padding: 15px;
  margin: 5px 0 22px 0;
  border: none;
  background: #f1f1f1;
}
</style>
