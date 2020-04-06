import axios from "axios";

const Api = (_) => {
  let api = axios.create({
    baseURL: "",
  });

  api.interceptors.request.use(async (config) => {
    config.headers["Content-Type"] = "application/json";
    return config;
  });

  return api;
};

export default Api;
