import React, { useState } from 'react';
import { Row } from 'antd';
import axios from 'axios';
import DefaultPage from '../DefaultPage/DefaultPage';

import './Login.css';
import Button from '../../Components/Button/Button';

const Login = () => {

    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');

    const handleSubmit = async (event) => {
        event.preventDefault();
        try {
            const response = await axios.post(`https://localhost:7297/api/Login?email=${encodeURIComponent(email)}&password=${encodeURIComponent(password)}`);

            console.log(response.data);
            // Verifique se o acesso foi permitido
            if (response.data === 'Acesso Permitido.') {
                // Defina a flag de login no localStorage
                localStorage.setItem('isLoggedIn', true);
                // Redirecione o usuário para a URL '/'
                window.location.href = '/';
            }
        } catch (error) {
            console.error('Ocorreu um erro:', error);
            // Lide com o erro, como exibindo uma mensagem para o usuário.
        }
    };

    return (
        <Row>
            <DefaultPage menu={false}>
                <div className='content-login'>
                    <div className='content'>
                        <form onSubmit={handleSubmit} className='form'>
                            <label>
                                Email:
                                <input type="email" value={email} onChange={(e) => setEmail(e.target.value)} />
                            </label>
                            <label>
                                Senha:
                                <input type="password" value={password} onChange={(e) => setPassword(e.target.value)} />
                            </label>
                            <div className='button-container'>
                                <Button type="submit" children="ENTRAR"/>
                            </div>
                        </form>
                    </div>
                </div>
            </DefaultPage>
        </Row>
    );
};

export default Login;
