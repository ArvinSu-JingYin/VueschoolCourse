<template>
    <p>
      <strong>{{ name }}</strong>
      <!-- provide Type 1: -->
      <!-- <YummyMealPrice :price="price" :currencySymbol="currencySymbol"/> -->

      <!-- provide Type 2: -->
      <YummyMealPrice :price="price"/>
      <button @click="addIoCart">Add to cart</button>
    </p>
  </template>
  
  <script>
  import YummyMealPrice from './YummyMealPrice.vue';
  
  export default {
    components: {
      YummyMealPrice
    },
      props: {
        name: String,
        price: Number,
        
        //provide Type 1:
        // currencySymbol: String 
      },
      setup(props, { emit }) {
        const addIoCart = () => emit('add-to-cart', props.name);
  
        return {
          addIoCart,
        };
      },
  };
  </script>
  
  <style>
  </style>