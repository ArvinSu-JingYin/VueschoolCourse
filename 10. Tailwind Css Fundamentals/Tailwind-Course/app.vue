<script setup>
import TheMainNav from "./components/TheMainNav.vue";
import { useDark } from "@vueuse/core";

const isDark = useDark();
</script>

<template>
  <div class="m-10">
    <input type="checkbox" v-model="isDark" />Dark Model
    <NuxtPage />
  </div>
</template>
