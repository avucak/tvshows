<template>
  <header>
    <div class="title">
      <h3>TV shows</h3>
    </div>
    <div>
      <button v-on:click="showLogin">Login</button>
      <button v-on:click="showSignup">Sign up</button>
    </div>
  </header>
</template>

<script>
export default {
  name: "Header",
  methods: {
    showLogin() {
      this.$emit("show-login");
    },
    showSignup() {
      this.$emit("show-signup");
    },
  },
};
</script>

<style scoped>
header {
  background: darkred;
  color: white;
  font-size: 30px;
  position: fixed;
  width: 100%;
  display: flex;
  justify-content: space-between;
  align-items: baseline;
}
button {
  background: white;
  border: none;
  padding: 10px 18px;
  margin: 24px 15px;
  font-size: 15px;
}

.title {
  padding-left: 8px;
}

h3 {
  margin: 15px;
}
</style>
