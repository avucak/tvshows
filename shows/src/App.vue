<template>
  <div>
    <Header />
    <DisplayShows />
    <LogIn />
  </div>
</template>

<script>
import DisplayShows from "./components/DisplayShows.vue";
import Header from "./components/Header.vue";
import LogIn from "./components/LogIn";
//import UserHeader from './components/UserHeader.vue'

export default {
  name: "App",
  components: {
    DisplayShows,
    Header,
    LogIn,
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
