let PlanComponent = {
    template: '#plan-template',
    props: {
        name: {type: String, required: true},
        selected: {type: Boolean, default: false}
    },
    data() {
        return {
            isSelected: this.selected,
        }
    },
    methods: {
        select() {
            this.isSelected = true;
            this.$emit('select', this.name);
        }
    }
}

let PlanPickerComponent = {
    components: {plan: PlanComponent},
    template: '#plan-picker-template',
    data() {
        return {
            plansPickers:['The Single1','The Curious2','The Addict3'],
            selectedPlan: null,
        }
    },
    methods: {
        selectPlan(plan) {
            this.selectedPlan = plan;
        }
    }
}

Vue.createApp({
    components: { 'plan-picker': PlanPickerComponent }
})
.mount('#app');
