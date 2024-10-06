<script lang="ts" setup>
import {Icon} from '@iconify/vue';
import CartCheckoutCCIcon from './CartCheckoutCCIcon.vue';
import CartCheckoutCheckbox from './CartCheckoutCheckbox.vue';
import CartCheckoutInput from './CartCheckoutInput.vue';
import CartCheckoutSteps from './CartCheckoutSteps.vue';
import CartCheckoutHamburger from './CartCheckoutHamburger.vue';
import CartCheckoutButton from './CartCheckoutButton.vue';

</script>

<template>
  <div class="flex flex-col justify-center h-full col-span-6 p-16">
    <!-- Header -->
    <header class="flex items-center justify-between">
      <CartCheckoutSteps />
      <CartCheckoutHamburger />
    </header>
    <h1 class="mt-10 mb-4 font-bold uppercase">Checkout</h1>

    <!-- Credit Cards -->
    <div class="flex items-center gap-4 mb-4">
      <CartCheckoutCCIcon 
      class="text-[#EA7C67] text-3xl opacity-100"
      icon="cib:visa"
      />
      <CartCheckoutCCIcon
      class="text-3xl"
      icon="cib:mastercard"
      />
      <CartCheckoutCCIcon
      class="text-2xl"
      icon="cib:paypal"
      />
      <CartCheckoutCCIcon
      class="text-[2.5rem]"
      icon="cib:apple-pay"
      />
      <CartCheckoutCCIcon
      class="text-[2.5rem]"
      icon="cib:google-pay"
      />
    </div>

    <!-- Form -->
     <div>
      <fieldset>
        <CartCheckoutInput
        class="w-11/12"
        label="Card Holder"
        value="John Doe"
        />

        <CartCheckoutInput
        class="w-12"
        label="MM/YY"
        value="09/18"
        />
      </fieldset>
     </div>
  </div>
</template>

<style>

</style>