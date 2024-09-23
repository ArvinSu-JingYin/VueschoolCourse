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

<style>
/* 當 <html> 元素有 .dark 類別時 */
.dark {
  background-color: #16171d; /* 深色背景 */
  color: #ffffff; /* 白色文字 */
}
</style>