const express = require("express");
const app = express();

app.get("/", (req, res) => {
  res.send("Run express server");
});

app.get("/api/hello", (req, res) => {
  res.json({ message: "Hello World" });
});

app.listen(3000, () => {
  console.log("Run server on port 3000");
});
