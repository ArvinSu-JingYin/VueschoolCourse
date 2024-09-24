<template>
  <fieldset>
    <legend>
      <ul>
        <li>grid grid-cols-3 gap-2</li>
        <li>
          sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 xl:grid-cols-5
          grid-flow-dense
        </li>
      </ul>
      grid grid-cols-3 gap-2 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4
      xl:grid-cols-5 grid-flow-dense
    </legend>
    <section
      class="grid grid-cols-3 gap-2 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 xl:grid-cols-5 grid-flow-dense"
    >
      <div>1</div>
      <div>2</div>
      <div>3</div>
      <div>4</div>
      <div>5</div>
      <div>6</div>
      <div>7</div>
      <div>8</div>
      <div>9</div>
      <div>10</div>
    </section>
    <hr class="my-10 border-gray-400 h-[2px]" />
  </fieldset>
</template>

<script lang="ts" setup>
</script>

<style scoped lang="scss">
div {
  @apply bg-slate-400 min-h-[100px] even:bg-zinc-500;
}
</style>
