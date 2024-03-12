import { Row } from 'antd'
import React, { useState } from 'react'
import DefaultPage from '../DefaultPage/DefaultPage'
import Button from '../../Components/Button/Button'
import './Register.css'
import axios from 'axios'

const Register = () => {

    const [nome, setNome] = useState('')
    const [email, setEmail] = useState('')
    const [celular, setCelular] = useState('')
    const [password, setPassword] = useState('')
    const [passwordConfirmation, setPasswordConfirmation] = useState('')

    const handleSubmit = async (event) => {
        event.preventDefault();

        // Verifica se as senhas coincidem
        if (password !== passwordConfirmation) {
            alert("As senhas devem ser iguais.");
            return;
        }

        // Cria um objeto com os dados a serem enviados
        const newCustomer = {
            nomeCompleto: nome,
            email,
            senha: password,
            celular
        };
        console.log('Dados:', newCustomer)
        try {
            // Faz a requisição POST para a URL especificada
            const response = await axios.post('https://localhost:7297/api/Cliente', newCustomer);

            // Verifica o código de status da resposta
            if (response.status === 201) {
                alert("Usuário criado com sucesso.");
                window.location.href = "/login"; // Redireciona para /login
            } else {
                console.log('Resposta:', response.data);
            }

            setNome('');
            setEmail('');
            setCelular('');
            setPassword('');
            setPasswordConfirmation('');
        } catch (error) {
            // Se houver um erro, exibe-o no console
            console.error('Erro:', error);
        }
    };

    return (

        <Row>
            <DefaultPage textHeader='CADASTRO' menu={false}>
                <div className='content-register'>
                    <div className='content'>
                        <form onSubmit={handleSubmit} className='form'>
                            <label>
                                Nome:
                                <input type="text" value={nome} onChange={(e) => setNome(e.target.value)} placeholder='  Insira seu nome completo' />
                            </label>
                            <label>
                                Email:
                                <input type="email" value={email} onChange={(e) => setEmail(e.target.value)} placeholder='  Insira seu email' />
                            </label>
                            <label>
                                Celular:
                                <input type="text" value={celular} onChange={(e) => setCelular(e.target.value)} placeholder='  Insira seu celular XXXXXXXXX' />
                            </label>
                            <label>
                                Senha:
                                <input type="password" value={password} onChange={(e) => setPassword(e.target.value)} placeholder='  Insira sua senha' />
                            </label>
                            <label>
                                Confirme sua senha:
                                <input type="password" value={passwordConfirmation} onChange={(e) => setPasswordConfirmation(e.target.value)} placeholder='  Confirme sua senha' />
                            </label>
                            <div className='button-container'>
                                <Button type="submit" children="Registrar" />
                            </div>
                        </form>                        
                    </div>
                    <div className="toGoBack-container">
                            <a href="/login">{"VOLTAR PARA LOGIN<"} </a>
                    </div>
                </div>
            </DefaultPage>
        </Row>
    )
}

export default Register