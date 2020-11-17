import axios from "axios";
const baseUrl = "https://www.episodate.com/api/";

export const getShow = (page) =>
  axios
    .get(baseUrl + "most-popular?page=" + page.toString())
    .then((response) => {
      console.log(response.data);
      return response.data;
    });
