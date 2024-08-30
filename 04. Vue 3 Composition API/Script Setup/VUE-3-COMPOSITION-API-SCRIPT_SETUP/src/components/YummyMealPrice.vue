<template>
  <span>{{ pricePretty2 }}</span>
</template>

<script>
import { computed, ref } from 'vue'
import { inject } from 'vue'

export default {
  props: {
    name: String,
    price: Number
  },
  setup(props) {
    const currencySymbol = inject('currencySymbol', ref('$'))
    const pricePretty2 = computed(() => {
      return `${currencySymbol.value}${props.price.toFixed(2)}`
    })

    return {
      pricePretty2,
      currencySymbol
    }
  }
}
</script>

<style>
</style>