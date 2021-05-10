<template>
  <div id="app">
    <div>
      <TheNavbar/>  
    </div>
    
    <div class="app">
      <TheHeader/>
      <TheContent/>
    </div>
    
  </div>
</template>

<script>
import TheNavbar from './components/TheNavbar.vue'
import TheHeader from './components/TheHeader.vue'
import TheContent from './components/TheContent.vue'

export default {
  name: 'App',
  components: {
    TheNavbar,
    TheHeader,
    TheContent
  }
}
</script>

<style>
*{
  margin: 0;
  padding: 0;
}
html{
      font-size: 13px;
    width: 100%;
    line-height: 1.5;
    letter-spacing: .01rem;
}
#app {
  display: flex;
}
.app{
  box-sizing: border-box;
  height: 100vh;
}
</style>
