let PlanComponent = {
    template: '#plan-template',
    props: {
        name: {type: String, required: true}
    },
}

let PlanPickerComponent = {
    components: {plan: PlanComponent},
    template: '#plan-picker-template',
    data() {
        return {
            plansPickers:['The Single1','The Curious2','The Addict3']
        }
    },
}

Vue.createApp({
    components: { 'plan-picker': PlanPickerComponent }
})
.mount('#app');
