import {ref} from 'vue'
import usePageRequests from './usePageRequests.js'
export default function useResource(resource){
  const { makeRequest } = usePageRequests()
  const items = ref([])
  const item = ref(null)
  const baseURL = `https://jsonplaceholder.typicode.com/${resource}`
  const fetchAll = async ()=> {
    items.value = await makeRequest(baseURL)
    items.value = await response.json()
  }
  const fetchOne = async (id) => {
    item.value = await makeRequest(`${baseURL}/${id}`)
    item.value = await response.json()
  }
  
  return {
    items,
    fetchAll,
    item,
    fetchOne
  }
}