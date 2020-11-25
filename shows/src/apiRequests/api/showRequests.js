import axios from "axios";
const baseUrl = "https://www.episodate.com/api/";

export function getShows() {
  return axios.get(baseUrl + "most-popular?page=1");
}
