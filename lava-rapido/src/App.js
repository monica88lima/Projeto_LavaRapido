import React, { useEffect, useState } from 'react';
import { BrowserRouter, Routes, Route, Navigate } from "react-router-dom";
import Home from './Pages/Home/Home';
import Login from './Pages/Login/Login';
import Status from './Pages/Status/Status';
import Timeline from './Pages/Timeline/Timeline';

import './App.css';
import Register from './Pages/Register/Register';
function App() {

  const [carFound, setCarFound] = useState(localStorage.getItem('carFound') === 'true');
  const [isLoggedIn, setIsLoggedIn] = useState(localStorage.getItem('isLoggedIn') === 'true');

  useEffect(() => {
    // Monitora alterações no localStorage e atualiza o estado carFound
    const handleStorageChange = () => {
      const storedCarFound = localStorage.getItem('carFound') === 'true';
      setCarFound(storedCarFound);
    };

    window.addEventListener('storage', handleStorageChange);

    // Limpa o evento de escuta ao desmontar o componente
    return () => {
      window.removeEventListener('storage', handleStorageChange);
    };
  }, []);


  useEffect(() => {
    // Monitora alterações no localStorage e atualiza o estado isLoggedIn
    const handleStorageChange = () => {
      const storedIsLoggedIn = localStorage.getItem('isLoggedIn') === 'true';
      setIsLoggedIn(storedIsLoggedIn);
    };

    window.addEventListener('storage', handleStorageChange);

    // Limpa o evento de escuta ao desmontar o componente
    return () => {
      window.removeEventListener('storage', handleStorageChange);
    };
  }, []);

  useEffect(() => {
    const checkLogoutTime = () => {
      const isLoggedIn = localStorage.getItem('isLoggedIn');
      if (isLoggedIn) {
        const loginTime = parseInt(localStorage.getItem('loginTime'));
        const currentTime = new Date().getTime();
        const elapsedTime = currentTime - loginTime;
        const minutesElapsed = elapsedTime / (1000 * 60);

        if (minutesElapsed >= 10) {
          // Remova o item de login
          localStorage.removeItem('isLoggedIn');
          // Redirecione para a página de login
          window.location.href = '/login';
        }
      }
    };

    const interval = setInterval(checkLogoutTime, 1000 * 60); // Verifica a cada minuto

    return () => clearInterval(interval);
  }, []);

  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path="/login" element={isLoggedIn === false ? <Login /> : <Navigate to="/" />} />
          <Route path="/register" element={isLoggedIn === false ? <Register /> : <Navigate to="/" />} />
          <Route path="/" element={isLoggedIn === true ? <Home /> : <Navigate to="/login" />} />
          <Route path="/status" element={isLoggedIn === true ? <Status /> : <Navigate to="/login" />} />

          <Route path="/timeline" element={carFound === true ?  <Timeline /> : <Navigate to="/status" />} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
