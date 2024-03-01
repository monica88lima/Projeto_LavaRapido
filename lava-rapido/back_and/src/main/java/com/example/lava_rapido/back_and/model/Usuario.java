package com.example.lava_rapido.back_and.model;

import jakarta.persistence.Entity;

@Entity
public class Usuario {
    Usuario con;

    public Usuario() {
        try {
            String url = String.format("jdbc:mysql://localhost:3308/lava_rapido");
            String user = "root";
            String pwd = "";

            Class.forName(pwd);
        } catch (Exception e) {
            // TODO: handle exception
            System.out.println("Error");
        }

    }
}
