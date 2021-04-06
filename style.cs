 body {
  background:#33d9b2;
  font-size: 12px;
}
/* font-family: 'Poppins', sans-serif; */
body, button, input {
  font-family: 'Righteous', cursive;
  font-weight: 700;
  letter-spacing: 1.4px;
}

.background {
  background: url("https://images.unsplash.com/photo-1531256379416-9f000e90aacc?ixlib=rb-1.2.1&ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&auto=format&fit=crop&w=1934&q=80");
  background-size: cover;
  display: flex;
  min-height: 95vh;
}

.container {
  flex:0 0 100px;
  margin: 70px;
  padding: 10px;
  opacity:0.85;
}

.screen {
  position: relative;
  background: #1b2146;
  border-radius: 15px;
  box-shadow: 10px 10px 30px #ddd;
}

.screen:after {
  content: '';
  display: block;
  position: absolute;
  top: 0;
  left: 20px;
  right: 20px;
  bottom: 0;
  border-radius: 15px;
  box-shadow: 10px 20px 40px rgba(0, 0, 0, .2);
  z-index: -1;
}

.screen-body {
  display: flex;
}

.screen-body-item {
  flex: 1;
  padding: 40px;
  /* font-family: 'Poppins', sans-serif; */
}

.screen-body-item.left {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}

.app-title {
  display: flex;
  /*flex-direction: column;*/
  border-radius: 20px;
  justify-content: center;
  align-items: center;
  color: #33d9b2;
  font-size: 40px;
  text-transform: uppercase;
  border: 4px solid #218c74;
  padding: 25px;
}

.app-form-group {
  margin-bottom: 10px;
  margin-left: -20px;
}

.app-form-group.buttons {
  margin-bottom: 10px;
  text-align: right;
}

.app-form-control {
  width: 90%;
  padding: 15px 0;
  background: none;
  border: none;
  border-bottom: 1px solid #666;
  color: #ddd;
  font-size: 16px;
  text-transform: uppercase;
  outline: none;
  transition: border-color .2s;
}

.app-form-control::placeholder {
  color: #FFF;
}

.app-form-control:focus {
  border-bottom-color: #ddd;
}

.btn-group button {
  align:center;
  display: inline-block;
  background-color: #1B2146;
  border: 3px solid #218c74;
  padding-top: 10px;
  padding-bottom: 10px;
  padding-left:20px;
  padding-right:20px;
  color: #33d9b2;
  font-size: 28px;
  cursor: pointer;
  outline:none;
  text-transform: uppercase;
  display: inline-block;
  float: left; /* Float the buttons side by side */
  margin-right:60px;
  margin-left:-20px;
  margin-top:20px;
}

.app-form-button:hover {
  color: red;
}

.showdata{
  text-align: center;
  color: white;
  font-size:  2.5rem;
  padding-top: -5px;
  padding-bottom: 1px;
}
footer{
    font-family: 'Poppins', sans-serif;
    font-size: 20px;
    font-weight: 400;
    color: black;
    background-color:white;
}
.box{
    /* background: #1B2146; */
    background: white;
    padding: 20px;
    border-radius: 15px;
    font-family: 'Poppins', sans-serif;
    font-weight: 400;
    font-size: 18px;
    display: none;
    color: black;
    box-shadow: 10px 10px 40px #218c74;
    margin-top: 30px;
    opacity: 0.95
}
