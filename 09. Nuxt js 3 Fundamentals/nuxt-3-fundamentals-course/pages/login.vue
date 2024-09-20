<script setup>
definePageMeta({
  layout: "plain",
});
</script>
<template>
  <form>
    <h1>Login</h1>
    <label for="username">Username</label>
    <input type="text" id="username" />
    <label for="password">Password</label>
    <input type="password" id="password" />
    <button>Login</button>
  </form>
</template>