import { Link } from "react-router-dom";
import { Formik, Form, Field, ErrorMessage } from "formik";
import * as Yup from "yup";

const validationSchema = Yup.object().shape({
    mobileNumber: Yup.string()
      .required("Mobile number is required")
      .matches(/^(\+\d{1,3}[- ]?)?\d{10}$/, "Mobile number must be in the valid"),
    email: Yup.string().email("Invalid email").required("Email is required"),
    panNumber: Yup.string().required("PAN number is required").matches(/[A-Z]{5}[0-9]{4}[A-Z]{1}/, "Pan number should be valid"),
    agreeTerms: Yup.boolean().oneOf([true], "You must agree to the Terms and Conditions"),
  });
  

export default function PersonalDetail() {
  return (
    <div className="Bamboo-personaldeatil">
      <div className="Bamboo-pd-card-1"></div>

      <div className="Bamboo-pd-card-2">
        <div className="Bamboo-pd-card-content">
          <div>
            <img alt="logo" src="../assets/back-arrow.svg" />
          </div>

          <div>
            <h1 className="headin">Personal Details</h1>
            <p className="para">Let’s begin with some necessary information and get you started</p>
          </div>

          <Formik
            initialValues={{
              mobileNumber: "",
              email: "",
              panNumber: "",
              agreeTerms: false,
            }}
            validationSchema={validationSchema}
            onSubmit={(values, { setSubmitting }) => {
              console.log(values);
              setSubmitting(false);
            }}
          >
            <Form className="personal-details-form">
              <div className="form-group">
                <label className="label-mobile">Enter mobile number linked with Aadhaar *</label>
                <br />
                <input
                className="input-disable"
                type="number"
                placeholder="+91"
                disabled
                />
                <Field
                  className="input-form-mobile"
                  type="text"
                  name="mobileNumber"
                  placeholder="Enter your mobile number"
                />
                <ErrorMessage name="mobileNumber" component="div" className="error-message" />
              </div>

              <div className="form-group">
                <label className="label-email">Registered/Personal e-mail address *</label>
                <br />
                <Field
                  className="input-form-email"
                  type="email"
                  name="email"
                  placeholder="Max 59 characters allowed"
                />
                <ErrorMessage name="email" component="div" className="error-message" />
              </div>

              <div className="form-group">
                <label className="label-pan">PAN (Personal Account Number) *</label>
                <br />
                <Field
                  className="input-form-pan"
                  type="text"
                  name="panNumber"
                  placeholder="xxx xxxx xxx"
                />
                <ErrorMessage name="panNumber" component="div" className="error-message" />
              </div>

              <div className="form-group-checkbox">
                <Field type="checkbox" name="agreeTerms" className="input-box" />
                <span>
                  &nbsp;I agree with <Link to='/terms'>Terms and Condition</Link>
                </span>
              </div>
              <ErrorMessage name="agreeTerms" component="div" className="error-message" />

              <div className="submit-input">
                <button type="submit" className="input-button">
                  submit
                </button>
              </div>
            </Form>
          </Formik>
        </div>

        <div className="bank-icon">
          <img alt="logo" src="../assets/bankicon.png" />
        </div>
      </div>
    </div>
  );
}
