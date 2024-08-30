<template>
  <p>
    <strong>{{ name }}</strong>
    <YummyMealPrice :price="price" />
    <button @click="addIoCart">Add to cart</button>
  </p>
</template>
  
<script setup>
// type 2: when using setup() and props, you can use defineProps()
const props = defineProps({
  name: String,
  price: Number
})

const emit = defineEmits(['add-to-cart'])

import YummyMealPrice from './YummyMealPrice.vue'

const addIoCart = () => emit('add-to-cart', props.name)
</script>

<!-- type 1: when using setup() and props, you can use second script tag -->
<!-- <script>
export default {
  props: {
    name: String,
    price: Number
  }
}
</script> -->
  
<style>
</style>