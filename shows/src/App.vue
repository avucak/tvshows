<template>
  <div>
    <Header v-on:show-login="showLogin" v-on:show-signup="showSignup" />
    <DisplayShows />
    <LogIn
      :showLoginModal="showLoginModal"
      v-on:close-login="closeLogin"
      v-on:show-signup="showSignup"
    />
    <Signup
      :showSignupModal="showSignupModal"
      v-on:close-signup="closeSignup"
      v-on:show-login="showLogin"
    />
  </div>
</template>

<script>
import DisplayShows from "./components/DisplayShows";
import Header from "./components/Header";
import LogIn from "./components/LogIn";
import Signup from "./components/Signup";
//import UserHeader from './components/UserHeader.vue'

export default {
  name: "App",
  components: {
    DisplayShows,
    Header,
    LogIn,
    Signup,
  },
  data() {
    return {
      showLoginModal: false,
      showSignupModal: false,
    };
  },
  methods: {
    showLogin() {
      this.showLoginModal = true;
    },
    closeLogin() {
      this.showLoginModal = false;
    },
    showSignup() {
      this.showSignupModal = true;
    },
    closeSignup() {
      this.showSignupModal = false;
    },
  },
};
//  font-family: Avenir, Helvetica, Arial, sans-serif;
</script>

<style>
#app {
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  font-family: tahoma;
}

body {
  margin: 0;
}
</style>
