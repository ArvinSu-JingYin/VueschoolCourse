<template>
  <div>
    <p>
      <strong>{{ name }}</strong>
      {{ price }}
      <button @click="addToCart">Add to Cart</button>
    </p>
  </div>
</template>

<script>
export default {
  props: {
    name: String,
    price: Number
  },
  setup(props, { emit }) {
    console.log(props.name)
    console.log(props.price)

    const addToCart = () => emit('add-to-cart', props.name)
    return {
      addToCart
    }
  }
}
</script>

<style>
</style>