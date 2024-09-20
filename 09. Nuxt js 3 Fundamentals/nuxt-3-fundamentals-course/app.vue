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
    <NuxtLayout>
      <NuxtPage />
    </NuxtLayout>
  </div>
</template>
