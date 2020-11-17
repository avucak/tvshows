<template>
  <div class="modal" v-if="showSignupModal">
    <div class="modal-content">
      <div>
        <span class="close" v-on:click="closeModal">&times;</span>
      </div>
      <form action="" class="form-container">
        <h1 class="title">Join TV shows!</h1>
        <div class="inputs">
          <label for="email">Email</label>
          <input type="text" placeholder="Enter Email" name="email" required />
        </div>
        <div class="inputs">
          <label for="username">Username</label>
          <input
            type="text"
            placeholder="Enter Username"
            name="username"
            required
          />
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

        <button type="submit" class="btn">Sign up</button>
        <div>
          Already have an account?
          <a href="#" v-on:click="closeSignupOpenLogin">Log in</a>
        </div>
      </form>
    </div>
  </div>
</template>

<script>
export default {
  name: "Signup",
  props: { showSignupModal: Boolean },
  methods: {
    closeModal() {
      this.$emit("close-signup");
    },
    closeSignupOpenLogin() {
      this.$emit("close-signup");
      this.$emit("show-login");
    },
  },
};
</script>

<style scoped>
.title {
  color: darkred;
}

.modal {
  position: fixed;
  z-index: 1;
  left: 0;
  top: 0;
  width: 100%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0.4);
}

.modal-content {
  background-color: #fefefe;
  margin: 10% auto;
  padding: 20px;
  border: 1px solid #888;
  width: 35%;
}

.close {
  color: #aaa;
  float: right;
  font-size: 28px;
  font-weight: bold;
  cursor: pointer;
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
