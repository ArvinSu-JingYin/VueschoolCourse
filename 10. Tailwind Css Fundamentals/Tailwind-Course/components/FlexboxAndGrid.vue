<template>
  <fieldset>
    <legend>grid grid-cols-4 gap-2</legend>
    <section class="grid grid-cols-4 gap-2">
      <div></div>
      <div></div>
      <div class="flex items-center justify-around col-span-3">
        <div class="w-16 !min-h-0 h-16 !bg-green-300"></div>
        <div class="w-16 !min-h-0 h-16 !bg-blue-300"></div>
        <div class="w-16 !min-h-0 h-16 !bg-green-300"></div>
        <div class="w-16 !min-h-0 h-16 !bg-blue-300"></div>
        <div class="w-16 !min-h-0 h-16 !bg-green-300"></div>
      </div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
    </section>
  </fieldset>
</template>

<script lang="ts" setup>
</script>

<style scoped>
div {
  @apply bg-gray-400 min-h-[100px] even:bg-gray-600;
}
</style>
