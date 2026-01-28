<script setup>
import {ref} from 'vue';

const output = ref("");

function print(title, data){
  output.value = `${title}\n${JSON.stringify(data, null, 2)}`;
}

/* ---------------------------------
   CALLBACK
----------------------------------*/
function getUsersCallback(callback) {
  fetch("https://jsonplaceholder.typicode.com/users")
    .then(res => res.json())
    .then(data => callback(null, data))
    .catch(err => callback(err));
}

function loadWithCallback() {
  getUsersCallback((err, users) => {
    if (err) return console.error(err);
    print("CALLBACK RESULT", users);
  });
}

/* ---------------------------------
   PROMISE
----------------------------------*/
function getUsersPromise() {
  return fetch("https://jsonplaceholder.typicode.com/users")
    .then(res => res.json());
}

function loadWithPromise() {
  getUsersPromise()
    .then(users => print("PROMISE RESULT", users))
    .catch(err => console.error(err));
}

/* ---------------------------------
   ASYNC / AWAIT
----------------------------------*/
async function loadWithAsync() {
  const res = await fetch("https://jsonplaceholder.typicode.com/users");
  const users = await res.json();
  print("ASYNC / AWAIT RESULT", users);
}

/* ---------------------------------
   SERIAL REQUEST
----------------------------------*/
async function loadSerial() {
  const userRes = await fetch(
    "https://jsonplaceholder.typicode.com/users/1"
  );
  const user = await userRes.json();

  const postRes = await fetch(
    `https://jsonplaceholder.typicode.com/posts?userId=${user.id}`
  );
  const posts = await postRes.json();

  print("SERIAL REQUEST", { user, posts });
}

/* ---------------------------------
   PARALLEL REQUEST
----------------------------------*/
async function loadParallel() {
  const [usersRes, postsRes] = await Promise.all([
    fetch("https://jsonplaceholder.typicode.com/users"),
    fetch("https://jsonplaceholder.typicode.com/posts")
  ]);

  const users = await usersRes.json();
  const posts = await postsRes.json();

  print("PARALLEL REQUEST", { users, posts });
}

</script>

<template>
  <div style="padding: 20px">
    <h1>Async Playground (Vue)</h1>

    <button @click="loadWithCallback">Callback</button>
    <button @click="loadWithPromise">Promise</button>
    <button @click="loadWithAsync">Async / Await</button>

    <br /><br />

    <button @click="loadSerial">Serial Request</button>
    <button @click="loadParallel">Parallel Request</button>

    <pre style="margin-top: 20px">{{ output }}</pre>
  </div>
</template>

<style scoped>
.logo {
  height: 6em;
  padding: 1.5em;
  will-change: filter;
  transition: filter 300ms;
}
.logo:hover { 
  filter: drop-shadow(0 0 2em #646cffaa);
}
.logo.vue:hover {
  filter: drop-shadow(0 0 2em #42b883aa);
}
</style>
