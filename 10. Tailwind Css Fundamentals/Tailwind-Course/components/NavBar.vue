<script setup lang="ts">
const active = ref(false)
</script>
<template>
  <header class="flex items-center justify-between bg-gray-800 p-2">
    <button class="flex w-10 flex-col gap-2">
      <span class="block h-1 w-full bg-white"></span>
      <span class="block h-1 w-full bg-white"></span>
      <span class="block h-1 w-full bg-white"></span>
    </button>
    <div class="flex items-center">
      <img
        src="/assets/pic/Plogo.png"
        alt="Logo"
        class="mr-3 aspect-[139/166] w-8"
      />
      <ul class="flex gap-1">
        <li
          class="cursor-pointer rounded bg-gray-900 px-2 py-1 text-gray-400 hover:bg-gray-500 hover:text-gray-100"
        >
          Home
        </li>
        <li
          class="cursor-pointer rounded bg-gray-900 px-2 py-1 text-gray-400 hover:bg-gray-500 hover:text-gray-100"
        >
          About
        </li>
        <li
          class="cursor-pointer rounded bg-gray-900 px-2 py-1 text-gray-400 hover:bg-gray-500 hover:text-gray-100"
        >
          Services
        </li>
        <li
          class="cursor-pointer rounded bg-gray-900 px-2 py-1 text-gray-400 hover:bg-gray-500 hover:text-gray-100"
        >
          Contact
        </li>
      </ul>
    </div>

    <div class="flex items-center gap-2">
      <svg
        class="h-6 w-6"
        viewBox="0 0 24 24"
        fill="none"
        xmlns="http://www.w3.org/2000/svg"
      >
        <path
          d="M12.0009 5C13.4331 5 14.8066 5.50571 15.8193 6.40589C16.832 7.30606 17.4009 8.52696 17.4009 9.8C17.4009 11.7691 17.846 13.2436 18.4232 14.3279C19.1606 15.7133 19.5293 16.406 19.5088 16.5642C19.4849 16.7489 19.4544 16.7997 19.3026 16.9075C19.1725 17 18.5254 17 17.2311 17H6.77066C5.47638 17 4.82925 17 4.69916 16.9075C4.54741 16.7997 4.51692 16.7489 4.493 16.5642C4.47249 16.406 4.8412 15.7133 5.57863 14.3279C6.1558 13.2436 6.60089 11.7691 6.60089 9.8C6.60089 8.52696 7.16982 7.30606 8.18251 6.40589C9.19521 5.50571 10.5687 5 12.0009 5ZM12.0009 5V3M9.35489 20C10.0611 20.6233 10.9888 21.0016 12.0049 21.0016C13.0209 21.0016 13.9486 20.6233 14.6549 20"
          stroke="#000000"
          stroke-width="2"
          stroke-linecap="round"
          stroke-linejoin="round"
        />
      </svg>
      <div class="relative">
        <button @click="($event) => (active = !active)">
          <img
            src="/assets/pic/people.jpg"
            alt="people"
            class="h-10 w-10 rounded-full ring-2 ring-white ring-offset-2"
          />
        </button>
        <ul
          v-if="active"
          class="absolute right-0 top-full flex min-w-[175px] flex-col rounded bg-white text-gray-800"
        >
          <li class="p-2 hover:bg-gray-100">Your Profile</li>
          <li class="p-2 hover:bg-gray-100">Settings</li>
          <li class="p-2 hover:bg-gray-100">SignOut</li>
        </ul>
      </div>
    </div>
  </header>
</template>

<script lang="ts" setup></script>

<style></style>
