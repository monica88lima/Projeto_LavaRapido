import React, { useState } from 'react';
import { Row } from 'antd';
import axios from 'axios';
import DefaultPage from '../DefaultPage/DefaultPage';
import './Login.css';
import Button from '../../Components/Button/Button';

const Login = () => {
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [errorMessage, setErrorMessage] = useState('');
    const [successMessage, setSuccessMessage] = useState('');
    const [messageType, setMessageType] = useState(null);

    const handleSubmit = async (event) => {
        event.preventDefault();
        try {
            const response = await axios.post(`https://localhost:7297/api/Login?email=${encodeURIComponent(email)}&password=${encodeURIComponent(password)}`);

            console.log(response.data);
            // Verifique se o acesso foi permitido
            if (response.data === 'Acesso Permitido.') {
                // Defina a flag de login no localStorage
                localStorage.setItem('isLoggedIn', true);
                // Registre o tempo de login
                localStorage.setItem('loginTime', new Date().getTime());
                // Atualize a mensagem de sucesso
                setSuccessMessage('Login efetuado com sucesso.');
                setMessageType('success');
                // Redirecione o usuário para a URL '/'
                window.location.href = '/';
            } else {
                setErrorMessage('Dados inválidos.');
                setMessageType('error');
            }
        } catch (error) {
            console.error('Ocorreu um erro:', error);
            // Se a resposta for um erro 400 (Bad Request), exibe a mensagem de erro
            if (error.response && error.response.status === 400) {
                setErrorMessage('Email ou Senha inválidos.');
                setMessageType('error');
            }
        }
    };

    return (
        <Row>
            <DefaultPage textHeader="LOGIN" menu={false}>
                <div className='content-login'>
                    <div className='content'>
                        <form onSubmit={handleSubmit} className='form'>
                            <div className='content-inputs'>
                                <label>
                                    Email:
                                    <input type="email" value={email} onChange={(e) => setEmail(e.target.value)} />
                                </label>
                                <label>
                                    Senha:
                                    <input type="password" value={password} onChange={(e) => setPassword(e.target.value)} />
                                </label>
                                {messageType === 'success' && <p className="success-message">{successMessage}</p>}
                                {messageType === 'error' && <p className="error-message">{errorMessage}</p>}
                            </div>
                            <div className='button-container'>
                                <Button type="submit" children="ENTRAR" />
                            </div>
                            <div className='register-container'>
                                <a href="/register">Registre-se aqui</a>
                            </div>
                        </form>
                    </div>
                </div>
            </DefaultPage>
        </Row>
    );
};

export default Login;