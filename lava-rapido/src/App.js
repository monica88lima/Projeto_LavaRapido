import './App.css';
import { BrowserRouter, Routes, Route } from "react-router-dom";


function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
            <Route path="/" element={<h1>login</h1>} />
            <Route path="/home" element={<h1>home</h1>} />
            <Route path="/status" element={<h1>status</h1>} />
            <Route path="/timeline" element={<h1>timeline</h1>} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
