// index.js
Page({

  data:{
    player:{}
  },


  onLoad(){

    console.log("页面加载");


    wx.request({

      url:"http://172.24.141.206:5084/api/Player",
    
      method:"GET",
    
      success:(res)=>{
    
        console.log("后端返回:",res.data);
    
        this.setData({
          player:res.data
        })
    
      },
    
      fail:(err)=>{
    
        console.log("请求失败:",err);
    
      }
    
    })

  }

})