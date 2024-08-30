<template>
    <div>
      <p>
        <strong>{{ name }}</strong>
        {{ pricePretty }}
        <button @click="addIoCart">Add to cart</button>
      </p>
      <!-- <br />
      <input type="text" v-model="pricePretty2" />
      <p>pricePrettySentence : {{ pricePrettySentence }}</p> -->
    </div>
  </template>
  
  <script>
  import { computed } from 'vue'
  import { ref } from 'vue'
  
  export default {
    props: {
      name: String,
      price: Number
    },
    setup(props, { emit }) {
      const addIoCart = () => emit('add-to-cart', props.name)
  
      // type3 : to use in computed
      const price = ref(props.price)
  
      const pricePretty2 = computed({
        get() {
          return `$${price.value.toFixed(2)}`
        },
        set(newPrice) {
          price.value = parseFloat(newPrice)
          alert(`Sorry, we can not accept ${newPrice}. Nice try though!`)
        }
      })
  
      // type4 : to use in computed
      const pricePrettySentence = computed(() => {
        return `The price of this item is ${pricePretty2.value}`
      })
      return {
        addIoCart,
        pricePretty2,
        pricePrettySentence
      }
    },
    // type1 : to use in computed
    computed: {
      pricePretty() {
        return `$${this.price.toFixed(2)}`
      }
    }
  }
  </script>
  
  <style>
  </style>