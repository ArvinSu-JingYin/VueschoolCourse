<template>
    <!-- provide Type 1: -->
    <!-- <span>{{ pricePretty }}</span> -->

    <!-- provide Type 2: -->
    <span>{{ pricePretty2 }}</span>
</template>

<script>
import { computed, ref } from 'vue'

//provide Type 2:
import { inject } from 'vue'

  export default {
    props: {
        name: String,
        price: Number,
        //provide Type 1:
        // currencySymbol: String
    },
    setup(props) {
        //provide Type 1:
        // const pricePretty = computed( () => {
        //   return `${props.currencySymbol}${props.price.toFixed(2)}`
        // });

        //provide Type 2:
        //provide Type 3: present did't provide value, child component will provide value. like currencySymbol('$').
        const currencySymbol = inject('currencySymbol', ref('$'))
        const pricePretty2 = computed( () => {
          return `${currencySymbol.value}${props.price.toFixed(2)}`
        });

        return {
            //provide Type 1:
            // pricePretty,

            //provide Type 2:
            pricePretty2,
            currencySymbol
        }
    }
}
</script>

<style>

</style>