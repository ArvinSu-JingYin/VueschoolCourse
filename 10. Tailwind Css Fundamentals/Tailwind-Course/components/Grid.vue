<template>
  <section>
    <fieldset>
      <legend>grid grid-cols-4</legend>
      <section class="grid grid-cols-4">
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
      </section>
    </fieldset>

    <hr class="my-10 border-gray-400 h-[2px]" />
    <fieldset>
      <legend>grid grid-cols-6 gap-2</legend>
      <section class="grid grid-cols-6 gap-2">
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
      </section>
    </fieldset>
    <hr class="my-10 border-gray-400 h-[2px]" />
    <fieldset>
      <legend>grid grid-cols-4 gap-x-2</legend>
      <section class="grid grid-cols-4 gap-x-2">
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
      </section>
    </fieldset>
    <hr class="my-10 border-gray-400 h-[2px]" />
    <fieldset>
      <legend>grid grid-cols-4 gap-y-2</legend>
      <section class="grid grid-cols-4 gap-y-2">
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
      </section>
    </fieldset>
    <hr class="my-10 border-gray-400 h-[2px]" />
    <fieldset>
      <legend>
        <ul>
          <li>grid grid-cols-5 gap-2</li>
          <li>col-span-2</li>
          <li>row-span-2</li>
          <li>col-span-2 row-span-2</li>
        </ul>
      </legend>
      <section class="grid grid-cols-5 gap-2">
        <div class="col-span-2"></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div class="row-span-2"></div>
        <div class="col-span-2 row-span-2"></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
      </section>
    </fieldset>
    <hr class="my-10 border-gray-400 h-[2px]" />
    <fieldset>
      <legend>
        <ul>
          <li>grid grid-cols-4 gap-2</li>
          <li>col-span-3</li>
        </ul>
      </legend>
      <section class="grid grid-cols-4 gap-2">
        <div></div>
        <div></div>
        <div class="col-span-3"></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
      </section>
    </fieldset>
    <hr class="my-10 border-gray-400 h-[2px]" />
    <fieldset>
      <legend>
        <ul>
          <li>
            grid grid-cols-4 gap-2 <b class="text-red-500">grid-flow-dense</b>
          </li>
          <li>col-span-3</li>
        </ul>
      </legend>
      <section class="grid grid-cols-4 gap-2 grid-flow-dense">
        <div></div>
        <div></div>
        <div class="col-span-3"></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
      </section>
    </fieldset>
  </section>
</template>

<script lang="ts" setup>
</script>

<style scoped>
div {
  @apply bg-gray-500 min-h-[100px] even:bg-gray-600;
}
</style>