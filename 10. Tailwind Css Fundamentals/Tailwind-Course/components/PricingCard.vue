<template>
  <div
    class="flex w-full flex-col justify-between rounded-lg border border-gray-200 bg-white p-6 text-center shadow-md dark:border-gray-700 dark:bg-gray-800"
  >
    <div>
      <h3 class="mb-4 text-xl font-semibold">{{ name }}</h3>
      <p class="mb-4 font-light text-gray-400 dark:text-gray-400 sm:text-lg">
        {{ description }}
      </p>
    </div>
    <div class="flex items-center justify-center">
      <span class="mr-2 inline-block text-5xl font-extrabold"
        >${{ price }}</span
      >
      <span class="text-gray-400">/month</span>
    </div>
    <ul role="list" class="mb-8 space-y-4 text-left">
      <li
        v-for="feature in features"
        :key="feature"
        class="items-top flex space-x-3"
      >
        <svg
          xmlns="http://www.w3.org/2000/svg"
          width="24"
          height="24"
          viewBox="0 0 24 24"
          fill="none"
          stroke="currentColor"
          stroke-width="2"
          stroke-linecap="round"
          stroke-linejoin="round"
          class="mt-1 h-4 w-4 text-green-500"
        >
          <polyline points="20 6 9 17 4 12"></polyline>
        </svg>
        <span>{{ feature }}</span>
      </li>
    </ul>
    <a href="#" class="block rounded bg-blue-600 p-4 px-4 py-2 text-white"
      >Get Started</a
    >
  </div>
</template>

<script lang="ts" setup>
defineProps<{
  price: number
  features: string[]
  name: string
  description: string
}>()
</script>

<script lang="ts">
export default {}
</script>
