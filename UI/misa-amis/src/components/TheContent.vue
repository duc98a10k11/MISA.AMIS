<template>
    <div class="content">
        <EmployeeList/>
    </div>
</template>

<script>
import EmployeeList from '../view/EmployeeList.vue'

export default {
    components:{
        EmployeeList
    },
    
}
</script>

<style scoped>
.content{
    background-color: #F4F5F6;
    height: calc(100% - 48px);
    /* box-sizing: border-box; */
}
</style>