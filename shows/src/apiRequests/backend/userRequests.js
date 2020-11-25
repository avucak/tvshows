import axios from "axios";
const baseUrl = "https://localhost:5001/api/";

export function postUser(userInfo) {
  return axios.post(baseUrl + "users", userInfo);
}

export function getUser(username, password) {
  return axios.get(
    baseUrl + "users/username=" + username + "&password=" + password
  );
}
