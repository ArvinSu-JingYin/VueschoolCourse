import { defineStore } from "pinia";
import { groupBy } from "lodash";
import { useAuthUserStore } from "./AuthUserStore";

export const useCartStore = defineStore("CartStore", {
    state: () => {
        return {
            items: [],
        };
    },
    getters: {
    //type 1
    // count() {
    //     return this.items.length;
    // },
    // isEmpty() {
    //     return this.count === 0;
    // }

    //type 2
    count: (state) => state.items.length,
    isEmpty: (state) => state.items.length === 0,
    grouped: (state) => 
        {
            const grouped = groupBy(state.items, item => item.name);
            const sorted = Object.keys(grouped).sort();
            let inOrder = {};
            sorted.forEach((key) => (inOrder[key] = grouped[key]));
            return inOrder;
        },
    groupCount: (state) => (name) => state.grouped[name].length,
    total: state => state.items.reduce((acc, item) => acc + item.price, 0)
    },
    actions: {
        checkout() {
            const authUserStore = useAuthUserStore();
            alert(`${authUserStore.username} just bought ${this.count} items at a total of $${this.total}`)
        },
        addItems(count,item)
        {
            count = parseInt(count);
            for (let index = 0; index < count; index++) {
                this.items.push({...item});
            }
        },
        clearItem(itemName) {
            this.items = this.items.filter(item => item.name !== itemName)
        },
        setItemCount(item, count) {
            this.clearItem(item.name);
            this.addItems(count, item);
        }
    }
})
