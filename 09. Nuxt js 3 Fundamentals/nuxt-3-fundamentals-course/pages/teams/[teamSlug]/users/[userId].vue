<script setup>
const route = useRoute();
const message = computed(() => {
  return `Team: ${route.params.teamSlug} User: ${route.params.userId}`;
});
</script>

<template>
  <div>
    <h1>{{ message }}</h1>
  </div>
</template>