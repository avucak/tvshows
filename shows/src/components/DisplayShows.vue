<template>
  <div class="shows" v-if="showInfo">
    <div v-for="show in showInfo.tv_shows" :key="show.id">
      <Show :imagePath="show.image_thumbnail_path" :showName="show.name" />
    </div>
  </div>
</template>

<script>
import Show from "./Show";
//import {getShows} from '../apiRequests/api/showRequests';
import axios from "axios";
const baseUrl = "https://www.episodate.com/api/";

export default {
  name: "DisplayShows",
  components: {
    Show,
  },
  data() {
    return {
      showInfo: null,
    };
  },
  mounted() {
    axios.get(baseUrl + "most-popular?page=1").then((response) => {
      console.log(response.data);
      this.showInfo = response.data;
    });
  },
};
</script>

<style scoped>
.shows {
  background-color: lightgray;
  padding: 150px 158px;
  display: flex;
  flex-wrap: wrap;
  left: 0;
}
</style>
