<script setup>
//use composable
//const isLoggedIn = useIsLoggedIn();

//use pinia
import { useUser } from "@/stores/User";
const user = useUser();
</script>

<template>
  <div>
    <nav style="display: flex; gap: 1rem; padding: 1rem; background: #eee">
      <NuxtLink to="/">Home</NuxtLink>
      <NuxtLink to="/movies">Movies</NuxtLink>
      <NuxtLink to="https://vueschool.io">Vue School</NuxtLink>

      <!-- use composable -->
      <!-- <NuxtLink v-if="!isLoggedIn" to="/login">Login</NuxtLink>
      <a href="#" v-else @click.prevent="isLoggedIn = false">Logout</a> -->

      <!-- use pinia -->
      <NuxtLink v-if="!user.isLoggedIn" to="/login">Login</NuxtLink>
      <a href="#" v-else @click.prevent="user.isLoggedIn = false">Logout</a>

      Test
    </nav>
    <slot></slot>
  </div>
</template>