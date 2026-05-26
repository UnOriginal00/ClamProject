import React from 'react'
import LoginForm from './LoginForm'
import SignUpForm from './SignUpForm'
import './AuthenticationFormStyleling.css'

type Props = {
  children: React.ReactNode;
}

const AuthenticationForm = ({children}: Props) => {
  return (
    <div className='authentication-form'>
        {children}
    </div>
  )
}

export default AuthenticationForm;