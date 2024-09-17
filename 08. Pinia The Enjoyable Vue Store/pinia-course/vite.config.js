import { defineConfig } from 'vite'
import vue from '@vitejs/plugin-vue'
const path = require('path')

// https://vitejs.dev/config/
export default defineConfig({
  resolve:{
    alias:{
      '@' : path.resolve(__dirname, './src')
    },
  },
  plugins: [vue()],
  define: {
    // Enable Vue DevTools in production environment
    '__VUE_PROD_DEVTOOLS__': true,
    
    // Enable detailed hydration mismatch warnings in production environment
    '__VUE_PROD_HYDRATION_MISMATCH_DETAILS__': true, 
  },
})