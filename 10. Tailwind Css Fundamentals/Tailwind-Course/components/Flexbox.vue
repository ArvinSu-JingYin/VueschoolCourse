<template>
  <div>
    <section class="flex flex-row-reverse gap-2">
      <h1 class="text-2xl">Flex-row-reverse</h1>
      <div
        v-for="i in 15"
        :key="i"
        class="flex-shrink-0 p-4 text-center text-white bg-gray-500 w-14 h-14"
      >
        {{ i }}
      </div>
    </section>
    <hr class="my-10 border-gray-400 h-[2px]" />
    <section class="flex flex-wrap gap-2 w-1/2">
      <h1 class="text-2xl">Flex-wrap</h1>
      <div
        v-for="i in 15"
        :key="i"
        class="flex-shrink-0 p-4 text-center text-white bg-gray-500 w-14 h-14"
      >
        {{ i }}
      </div>
    </section>
    <hr class="my-10 border-gray-400 h-[2px]" />
    <section class="flex flex-wrap justify-center gap-2 w-1/2">
      <h1 class="text-2xl">Flex-wrap-justify-center</h1>
      <div
        v-for="i in 15"
        :key="i"
        class="flex-shrink-0 p-4 text-center text-white bg-gray-500 w-14 h-14"
      >
        {{ i }}
      </div>
    </section>
    <hr class="my-10 border-gray-400 h-[2px]" />
    <section class="flex flex-wrap justify-end gap-2 w-1/2">
      <h1 class="text-2xl">Flex-wrap-justify-end</h1>
      <div
        v-for="i in 15"
        :key="i"
        class="flex-shrink-0 p-4 text-center text-white bg-gray-500 w-14 h-14"
      >
        {{ i }}
      </div>
    </section>
    <hr class="my-10 border-gray-400 h-[2px]" />
    <section class="flex flex-wrap justify-around gap-2 w-1/2">
      <h1 class="text-2xl">Flex-wrap-justify-around</h1>
      <div
        v-for="i in 15"
        :key="i"
        class="flex-shrink-0 p-4 text-center text-white bg-gray-500 w-14 h-14"
      >
        {{ i }}
      </div>
    </section>
    <hr class="my-10 border-gray-400 h-[2px]" />
    <section class="flex flex-col flex-wrap justify-around gap-2 h-[50vh]">
      <h1 class="text-2xl">Flex-wrap-justify-around</h1>
      <div
        v-for="i in 15"
        :key="i"
        class="flex-shrink-0 p-4 text-center text-white bg-gray-500 w-14 h-14"
      >
        {{ i }}
      </div>
    </section>
    <hr class="my-10 border-gray-400 h-[2px]" />
    <section class="flex flex-wrap justify-around gap-2">
      <h1 class="text-2xl">Flex-wrap-justify-around</h1>
      <div
        v-for="i in 15"
        :key="i"
        class="flex-shrink-0 p-4 text-center text-white bg-gray-500 w-14 h-14"
        :style="{ height: `${i * 30 + 30}px` }"
      >
        {{ i }}
      </div>
    </section>
    <hr class="my-10 border-gray-400 h-[2px]" />
    <section class="flex flex-wrap justify-around gap-2 items-center">
      <h1 class="text-2xl">Flex-wrap-justify-around</h1>
      <div
        v-for="i in 15"
        :key="i"
        class="flex-shrink-0 p-4 text-center text-white bg-gray-500 w-14 h-14"
        :style="{ height: `${i * 30 + 30}px` }"
      >
        {{ i }}
      </div>
    </section>
    <hr class="my-10 border-gray-400 h-[2px]" />
    <section class="flex flex-wrap justify-around gap-2 items-end">
      <h1 class="text-2xl">Flex-wrap-justify-around</h1>
      <div
        v-for="i in 15"
        :key="i"
        class="flex-shrink-0 p-4 text-center text-white bg-gray-500 w-14 h-14"
        :style="{ height: `${i * 30 + 30}px` }"
      >
        {{ i }}
      </div>
    </section>
  </div>
</template>
