<template>
  <div class="home">
    <div class="row">
      <div class="col-sm" v-for="i in list" :key="i">
        <div class="card" style="width: 18rem;margin-top: 2%;">
          <img src="../assets/logo.png" class="card-img-top" alt="...">
          <div class="card-body">
            <h5 class="card-title">项目名</h5>
            <p class="card-text">项目简介</p>
            <a href="#" class="btn btn-primary">跳转链接</a>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'Home',
  components: {
    HelloWorld
  },
  data(){
    return{
      list: [1,2,3,4,5,6]
    }
  }
}
</script>
