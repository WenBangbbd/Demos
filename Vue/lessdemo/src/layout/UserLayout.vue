<template>
  <div id="container">
    <div class="user-layout-lang">
      <a href=""><img src="../assets/logo.png" alt="" /></a>
    </div>
    <a-layout>
      <a-layout-header class="header">
        <a href="/">
          <img class="logo" src="../assets/logo.png" alt="" />
          <span class="title">登录页面</span>
        </a>
        <div class="desc">的撒法士大夫士大夫士大夫撒旦发生发射点撒旦飞洒地方撒旦飞洒发生大法师到底发生</div>
      </a-layout-header>
      <a-layout-content>Content</a-layout-content>

      <a-layout-footer class="root">
        <div class="link">
          <a href="_self">帮助</a>
          <a href="_self">隐私</a>
          <a href="_self">条款</a>
        </div>
      </a-layout-footer>
    </a-layout>
  </div>
</template>

<script>
export default {
  name: "UserLayout",
  data() {
    return {};
  },
};
</script>

<style lang='less' scoped>
#container {
  .user-layout-lang {
    text-align: right;
    line-height: 44px;
    height: 40px;
    img {
      width: 20px;
      height: 20px;
    }
  }
  .ant-layout-header {
    text-align: center;
    padding: 32px 0 24px;
    .logo {
      height: 44px;
      vertical-align: middle;
      margin-right: 16px;
      border-style: none;
    }
    .title {
      font-size: 33px;
      color: rgba(0, 0, 0, 0.85);
      font-family: Avenir, "Helvetica Neue", Arial, Helvetica, sans-serif;
      font-weight: 600;
      position: relative;
      top: 2px;
    }
    .desc {
      font-size: 14px;
      color: rgba(0, 0, 0, 0.45);
      margin-top: 12px;
      margin-bottom: 40px;
    }
  }
  .root {
    // position: absolute;
    width: 100%;
    bottom: 0;
    padding: 0 16px;
    margin: 48px 0 24px;
    text-align: center;
    a {
      color: rgba(0, 0, 0, 0.45);
      transition: all 0.3s;
      &:not(:last-child) {
        margin-right: 40px;
      }
    }
  }
}
</style>
