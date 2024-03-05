import './App.css';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Home from './Pages/Home/Home';
import Login from './Pages/Login/Login';
import Status from './Pages/Status/Status';
import Timeline from './Pages/Timeline/Timeline';


function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
        <Route path="/" element={<Login />} />
            <Route path="/home" element={<Home />} />
            <Route path="/status" element={<Status />} />
            <Route path="/timeline" element={<Timeline />} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
