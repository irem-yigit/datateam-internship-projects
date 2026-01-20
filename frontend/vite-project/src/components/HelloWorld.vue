<script setup>
import { ref } from 'vue'

defineProps({
  msg: String,
})

</script>

<template>
  <h1>{{ msg }}</h1>

  <p class="hello-world">Hello World</p>
</template>

<style scoped>
.hello-world {
  color: #888;
}
</style>
