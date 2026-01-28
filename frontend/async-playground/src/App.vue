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



</script>

<template>
  <div>
    <a href="https://vite.dev" target="_blank">
      <img src="/vite.svg" class="logo" alt="Vite logo" />
    </a>
    <a href="https://vuejs.org/" target="_blank">
      <img src="./assets/vue.svg" class="logo vue" alt="Vue logo" />
    </a>
  </div>
  <HelloWorld msg="Vite + Vue" />
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
