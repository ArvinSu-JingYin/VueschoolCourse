<script setup>
useHead({
  //title
  // title: "Nuxt Movies",

  //title template
  titleTemplate: (titleChunk) => {
    return titleChunk ? `${titleChunk} - Nuxt Movies` : "Nuxt Movies";
  },
});
</script>

<template>
  <div>
    <nav style="display: flex; gap: 1rem; padding: 1rem; background: #eee">
      <NuxtLink to="/">Home</NuxtLink>
      <NuxtLink to="/movies">Movies</NuxtLink>
      <NuxtLink to="https://vueschool.io">Vue School</NuxtLink>
    </nav>
    <NuxtPage />
  </div>
</template>
