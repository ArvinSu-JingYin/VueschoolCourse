<script lang="ts" setup>
const props = defineProps<{
  label: string;
  class?: string;
}>();

function slugify(str: string) {
  return str.toLowerCase().replace(/\s+/g, '-').replace(/[^a-z0-9-]/g, '');
}

// The defineOptions function is used to set component options in the <script setup> syntax.
// By setting inheritAttrs to false, we prevent the component from automatically inheriting
// attributes from the parent component. This allows us to have more control over which
// attributes are applied to the root element of the component.
defineOptions({
  inheritAttrs: false
});
</script>
<template>
  <div :class="props.class">
    <input 
      class="block focus:border-[#EA7C67]"
      v-bind="$attrs"
      :id="slugify(label)"
    >
    <label 
    class="text-xs text-gray-500"
    :for="slugify(label)"></label>
  </div>
</template>



<style>

</style>